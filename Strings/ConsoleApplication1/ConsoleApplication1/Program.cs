using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Solution
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string test = isPalindrome(a);
            Console.WriteLine(test);
            Console.ReadLine();
        }


        static string isPalindrome(string input)
        {
            Dictionary<char, int> dt = new Dictionary<char, int>();
            for(int i=0; i< input.Length; i++)
            {
                if (!dt.ContainsKey(input[i]))
                {

                    dt.Add(input[i], 1);
                }
                else
                {
                    dt[input[i]] += 1;
                }
            }
            int countsnottwo = dt.Count(x => x.Value%2 == 1);
            int countstwo = dt.Count(x => x.Value % 2 == 0);

            if (countsnottwo==1 || countstwo >= 1)
            {
                return ("Palindrome");
            }
            else
            {
                return ("Not Palindrome");

            }
        }
    }
}
