using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

public class Program
{


    public class StringRepository
    {
	
		Dictionary<int, string> input;
		int Curr = 1;
		readonly object _lock = new Object();
		
		public StringRepository(Dictionary<int, string> input)
		{
			this.input = input;
		}
		
        public virtual string Get(int id)
        {
			if(input.ContainsKey(id))
			{
			string inputKey = input[id];
				return inputKey;
			}
            throw new NotImplementedException();
        }

        public virtual int Save(string item)
        {
			lock(_lock){
				input.Add(Curr, item);
				Curr++;
				return Curr - 1;
			}
        }

        public virtual void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }

    public static class TemperatureApi
    {
        public static List<TemperatureResult> GetTemperatures(List<string> zipCodes)
        {

        List<TemperatureResult> zipTemperaturesList = new List<TemperatureResult>();
			var tasks = new List<Task<int>>();
			
			for(int i=0; i<zipCodes.Count(); i++)
			{
				tasks.Add(GetTemperature(zipCodes[i]));
	              
				
				
			//	TemperatureResult currTemperature = new TemperatureResult(zipCodes[i], zipTemperature);
				//zipTemperaturesList.Add(currTemperature);
			}
			 Task.WaitAll(tasks.ToArray());
			
			 
			
			return zipTemperaturesList;
        	throw new NotImplementedException();
        }


        public static Task<int> GetTemperature(string zipCode)
        {
            return Task.Factory.StartNew(() =>
            {
                var rnd = new Random();
                Thread.Sleep(rnd.Next(1, 100));
                return Convert.ToInt32(Math.Floor(Convert.ToDouble(zipCode) / 100));
            });
        }
    }

    public static void Main()
    {
        try
        {
            var tp = new TestPlan((message, logType) => {
                Console.WriteLine(message);
            });

            tp.Describe("My temperature library", it =>
            {
                it("should return the correct temperature for a given zip code", () =>
                {
                    var iTemp = TemperatureApi.GetTemperature("07410").Result;

                    Assert.AreEqual(74, iTemp);
                });

                it("should return the correct temperature for an array of zip codes", () =>
                {
                    var results = TemperatureApi.GetTemperatures(new List<string>() { "07410", "07656", "07845" });
                    Assert.AreEqual(3, results.Count);
                    Assert.AreEqual(74, results.Find(x => x.ZipCode == "07410").Temperature);
                    Assert.AreEqual(76, results.Find(x => x.ZipCode == "07656").Temperature);
                    Assert.AreEqual(78, results.Find(x => x.ZipCode == "07845").Temperature);
                });
            });

            tp.Describe("My Repository", it =>
            {
                it("should save a single item.", () =>
                {
                    var repo = new StringRepository();

                    int id = repo.Save("Item 1");
                    Assert.AreEqual("Item 1", repo.Get(id));
                });

                it("should remove a single item.", () =>
                {
                    var repo = new StringRepository();

                    int id = repo.Save("Item 1");
                    repo.Delete(id);
                    Assert.AreEqual(null, repo.Get(id));
                });

                it("should save concurrent items.", () =>
                {
                    var repo = new StringRepository();
                    var iterations = 10;

                    var list = new List<Task<int>>();
                    for(var i = 0; i < iterations; i++)
                    {
                        var iCopy = i; // create a local block scoped copy
                        list.Add(Task.Run(() =>
                        {
                            int id = repo.Save("Item " + iCopy);
                            return id;
                        }));
                    }
                    
                    Task.WaitAll(list.ToArray());

                    for (var i = 0; i < iterations; i++)
                    {
                        Assert.AreEqual("Item " + i, repo.Get(list[i].Result));
                    }
                    
                });
            });

            tp.Describe("My UniqueStringRepository", it =>
            {
                it("should only allow saving unique items", () =>
                {
                    var repo = new UniqueStringRepository();

                    int id1 = repo.Save("Item 1");
                    int id2 = repo.Save("Item 2");
                    int id3 = repo.Save("Item 1");
                    int id4 = repo.Save("Item 2");

                    Assert.AreEqual(id1, id3);
                    Assert.AreEqual(id2, id4);
                });
            });

            tp.Run().Wait();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class TemperatureResult
{
    public string ZipCode { get; set; }
    public int Temperature { get; set; }

    public TemperatureResult(string zipCode, int temperature)
    {
        ZipCode = zipCode;
        Temperature = temperature;
    }
}





















public static class Assert
{
    public static void AreEqual(string expected, string actual)
    {
        IsTrue(expected == actual, $"expected {expected} and received {actual}");
    }

    public static void AreEqual(int expected, int actual)
    {
        IsTrue(expected == actual, $"expected {expected} and received {actual}");
    }

    public static void AreEqual(double expected, double actual)
    {
        IsTrue(expected == actual, $"expected {expected} and received {actual}");
    }

    public static void AreEqual(bool expected, bool actual)
    {
        IsTrue(expected == actual, $"expected {expected} and received {actual}");
    }

    public static void IsTrue(bool condition)
    {
        IsTrue(condition, $"expected {true} and received {condition}");
    }

    public static void IsTrue(bool condition, string message)
    {
        if (!condition)
            Fail(message);
    }

    public static void Fail()
    {
        Fail("fail was called");
    }
    public static void Fail(string message)
    {
        throw new Exception(message);
    }
}

public class TestBody
{
    public string Description { get; set; }
    public List<TestDefinition> Tests { get; set; }

    public TestBody(string description)
    {
        Description = description;
        Tests = new List<TestDefinition>();
    }
}

public class TestDefinition
{
    public string Description { get; set; }
    public Action AsyncMethod { get; set; }

    public TestDefinition(string description, Action testMethod){
        Description = description;
        AsyncMethod = testMethod;
    }
}

public enum LogType
{
    Info,
    Error,
    Success
};

public class TestPlan {

    Action<string, LogType> _logger = null;
    List<TestBody> _testBodies = new List<TestBody>();
    const string PADDING = "   ";

    public TestPlan(Action<string, LogType> logger)
    {
        if(logger == null)
        {
            throw new ArgumentNullException("logger");
        }
        _logger = logger;
    }

    public void Describe(string description, Action<Action<string, Action>> tests)
    {
        var body = new TestBody(description);

        tests((string testDescription, Action test) => {
            body.Tests.Add(new TestDefinition(testDescription, test));
        });

        _testBodies.Add(body);
    }


    private async Task ExecuteTest(TestDefinition test)
    {
        try
        {
            var task = Task.Factory.StartNew(test.AsyncMethod);
            var timeoutOrComplete = Task.WhenAny(task, Task.Delay(5000));
            var resultTask = await timeoutOrComplete;
            if (resultTask != task)
            {
                throw new Exception("Async Test did not complete with in 5 seconds.");
            }
            await resultTask; // so we get our errors

            _logger($"{PADDING}Passed: {test.Description}", LogType.Success);
        }
        catch (Exception x)
        {
            _logger($"{PADDING}Error: {test.Description}", LogType.Error);
            _logger($"{PADDING}{PADDING}{x.Message}", LogType.Error);
        }
    }

    public async Task ExecuteTestBody(TestBody testBody)
    {
        _logger(testBody.Description, LogType.Info);
        var tasks = testBody.Tests.Select(i => ExecuteTest(i));
        await Task.WhenAll(tasks);
    }

    public async Task Run() {
        for(var i = 0; i < _testBodies.Count; i++)
        {
            //execute in order
            await ExecuteTestBody(_testBodies[i]);
        }
    }
}

