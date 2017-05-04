using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompression
{
    class Program
    {
        public static string CompressBad(string s1)
        {
            string compressesString = "";
            int countofChar = 1;


            for (int i=0;i<s1.Length;i++)
                {

                if((i+1) >= s1.Length || s1[i] !=s1[i+1])
                {
                    compressesString = compressesString + s1[i]+countofChar;
                    countofChar = 1;
                }
                else 
                {
                    countofChar++;
                }
            }
            if (compressesString.Length < s1.Length)
            {
                return compressesString;
            }
            else
            {
                return s1;
            }
        }

        static void Main(string[] args)
        {
            string compressString = Console.ReadLine();

            string result = CompressBad(compressString);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
