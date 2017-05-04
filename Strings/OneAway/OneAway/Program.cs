using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneAway
{
    class Program
    {

        bool oneEditAway(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                return oneReplaceAway(s1, s2);
            }
            if (s1.Length > s2.Length)
            {
                return oneInsertAway(s1, s2);
             }
            else
            {
                return oneInsertAway(s2, s1);
            }
        }

        bool oneReplaceAway(string s1, string s2)
        {
            bool foundDiffeerence = false;
            for(int i=0; i< s2.Length; i++)
            {
                if(s2[i]!=s1[i])
                {
                    if(foundDiffeerence)
                    {
                        return false;
                    }

                    foundDiffeerence = true;
                }
            }

            return true;
        }

        bool oneInsertAway(string s1, string s2)
        {
            int i = 0;
            int j = 0;
            while(i<s1.Length && j<s2.Length)
            {
                if(s1[i] != s2[j])
                {
                    if(i!=j)
                    {
                        return false;
                    }
                    i++;
                }
                else
                {
                    i++;
                    j++;
                }
                
            }

            return true;
        }

        static void Main(string[] args)
        {

        }
    }
}
