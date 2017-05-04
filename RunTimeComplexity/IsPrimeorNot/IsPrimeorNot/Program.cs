using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeorNot
{
    class Program
    {
        public static void isPrimeorNot(int input)
        {
            List<int> primes = new List<int>();
            if (input == 1)
            {
                Console.WriteLine("Not prime");

            }
            else
            {
                for (int i = 1; i <= Math.Sqrt(input); i++)
                {
                    if (input % i == 0)
                    {
                        primes.Add(i);
                    }
                }
                if (primes.Count > 1)
                {
                    Console.WriteLine("Not prime");

                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
        }
        static void Main(string[] args)
        {
            int cnt = Convert.ToInt32(Console.ReadLine());
            while(cnt-->0)
            {
                isPrimeorNot(Int32.Parse(Console.ReadLine()));
            }
        }
    }
}
