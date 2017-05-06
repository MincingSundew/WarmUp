using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsRotation
{
    class Program
    {

        public static bool isRotation(string s1, string s2)
        {
            if (s2.Length == s2.Length && s1.Length > 0)
            {
                string s1s1 = s1 + s1;

                return s1s1.Contains(s2);               
            }
            return false;
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            bool result = isRotation(s1, s2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
