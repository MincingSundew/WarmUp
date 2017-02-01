using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            try
            {
              Console.WriteLine(Int32.Parse(S));
            }
            catch
            {
                Console.WriteLine("Bad String");
            }

        }
    }
}
