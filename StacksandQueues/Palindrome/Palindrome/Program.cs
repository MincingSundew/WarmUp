using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Solution
    {
        LinkedList<char> Queuey;
        LinkedList<char>  Stacky;
        public Solution()
        {
            Queuey = new LinkedList<char>();
            Stacky = new LinkedList<char>();
        }

        public void pushCharacter(char ch)
        {
            Stacky.AddLast(ch);
        }

        public void enqueueCharacter(char ch)
        {
            Queuey.AddLast(ch);
        }

        public char popCharacter()
        {
            char FirstValue = Stacky.First.Value;
            Stacky.RemoveFirst();
            return FirstValue;
          }

        public char dequeueCharacter()
        {
            char LastValue = Queuey.Last.Value;
            Queuey.RemoveLast();
            return LastValue;
        }


    }


    class Program
    {
        static void Main(String[] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
                Console.ReadLine();
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
                Console.ReadLine();
            }
        }
    }
}

