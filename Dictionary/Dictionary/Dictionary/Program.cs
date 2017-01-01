using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dictionary
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int total = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> PhoneList = new Dictionary<string, string>();
            for (int i =0; i<=total-1; i++)
            {
                string[] addName = Console.ReadLine().ToString().Split(' ');
               
                PhoneList.Add(addName[0], addName[1]);               
            }
            string input;
            
            do
            {
                string Output = null;

                input = Console.ReadLine();
                if (PhoneList.ContainsKey(input))
                {
                    PhoneList.TryGetValue(input, out Output);
                    Console.WriteLine(input + "=" + Output);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            } while (input != null);


        }
    }
}
