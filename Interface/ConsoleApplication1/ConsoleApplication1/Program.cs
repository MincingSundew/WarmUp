using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
       
    }
    class Calculator:AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sumDivisor = 0;
            for(int i=1; i<= n; i++)
            {
                if(n%i==0)
                {
                    sumDivisor = sumDivisor +i;
                }
            }

            return sumDivisor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
           Console.WriteLine(c.divisorSum(8));
            Console.ReadLine();
        }
    }
}
