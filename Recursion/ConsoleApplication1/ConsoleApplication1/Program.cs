using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
                {
                return n * Factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
    }
}
