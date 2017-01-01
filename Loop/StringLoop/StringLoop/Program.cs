using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<size; i++)
            {
                string input = Console.ReadLine();
                string even = null;
                string odd = null;
                for(int j=0; j<input.Length; j++ )
                {
                    if(j%2 == 0)
                    {
                        even = even + input[j];
                    }
                    else
                    {
                        odd = odd + input[j];
                    }
                }
                Console.WriteLine(even + " " + odd);
            }
        }
    }
}
