using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneEditAway
{
    class Program
    {
        //hello helloo
        //hello jello
        //hello jelloo

        public static bool isOneEditInsertAway(string S1, string S2)
        {
            if(S1 == S2)
            {
                return isOneEditAway(S1, S2);
            }
            else
            {
                if(S1 > S2)
                { }

            }
        }

        public static bool isOneEditAway(string s1, string s2)
        {
            int i = s1.Length;
            int count = 0;
            while (i > 0)
            {
                if (s1[i] != s2[i])

                {
                    if(count > 1)
                    {
                        return false;
                    }
                    count++;
                }
                i++;
            }
            return true;
        }

        public static bool isOneInsertAway(string s1, string s2)
        {
            return true;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(isOneEditInsertAway("hello", "jello"));
            Console.ReadLine();
        }
    }
}
