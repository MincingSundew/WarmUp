using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomError
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException(string message) : base(message)
        {
        }
    }
    class Calculator
    {
        public  int power(int n, int p)
        {
            if(n<0 || p<0)
            {
                throw new NegativeValueException("n and p should be non-negative");
            }
            int result = 1;
            for(int i=1; i<= p; i++)
            {
                result = result * n;
            }
            return result;
        }
    }

    class Solution
    {
        static void Main(String[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
}
