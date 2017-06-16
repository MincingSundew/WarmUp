using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {

        public static int reverse(int x)
        {
          

            long result = 0, old = x;
            
     while(x != 0)
            {
                result = result*10 + x % 10;
                x = x / 10;

                if (result > Int32.MaxValue || result < Int32.MinValue)
                {
                    return 0;
                }
            }
            
                return (int)result;
            
  
         
           
        }

        static void Main(string[] args)
        {
           int x =  reverse(-123);

            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
