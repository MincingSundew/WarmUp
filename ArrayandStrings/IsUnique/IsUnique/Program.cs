using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsUnique
{
    interface ISampleInterface
    {
        void SampleMethod();
    }

    interface ISampleInterface2
    {
        void SampleMethod();
    }

    class ImplementationClass : ISampleInterface, ISampleInterface2
    {
        // Explicit interface member implementation: 
        void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("sample interface");
            // Method implementation.
        }
        void ISampleInterface2.SampleMethod()
        {
            // Method implementation.
            Console.WriteLine("sample interface2");
        }
    }
    class Program
    {
        public static bool IsUnique(string sample)
        {
            sample = Sort(sample);
            for(int i = 0; i<=sample.Length -1; i++)
            {
                if(sample[i]==sample[i+1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsUniquewithoutAddDatastructures(string sample)
        {
            Boolean[] charset = new Boolean[128];
            if(sample.Length>128)
            {
                return false;
            }
                for (int i = 0; i < sample.Length; i++)
            {
                int val = sample[i];
                if (charset[val])
                {
                    return false;
                }
                else
                {
                    charset[val] = true;
                }
            }
            return true;
        }
        public static bool IsPermutation(string S1, string S2)
        {
            int[] CharCount = new int[128];
            if(S1.Length!=S2.Length)
            {
                return false;
            }
            for(int i=0; i<S1.Length; i++)
            {
                CharCount[S1[i]]++;
            }
            for (int i = 0; i < S2.Length; i++)
            {
                CharCount[S2[i]]--;
                if(CharCount[S2[i]]<0)
                {
                    return false;
                }
            }
            
            return true;
        }

        public static string URLify(char[] url, int urlLength)
        {
            int spaceCount=0, index =0;
            for(int i=0;i< urlLength; i++)
            {
                if(url[i] == ' ')
                {
                    spaceCount++;
                }
            }
            index = urlLength + 2 * spaceCount;
            if (urlLength < url.Length)
            { url[urlLength] = '\0'; }
            for (int i= urlLength - 1; i>=0; i--)
            {
                if (url[i] == ' ')
                {
                    url[index - 1] = '0';
                    url[index - 2] = '2';
                    url[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    url[index-1] = url[i];
                    index--;
                }
            }
            

            string editedString = new string(url);
            return editedString;
        }
        public static string Sort(string sample)
        {
            char[] a = sample.ToCharArray();
            Array.Sort(a);
            return new string(a);
        }

        static void Main(string[] args)
        {
            string input = "Mr John s      ";
            char[] charArray = input.ToCharArray();
           Console.WriteLine(URL(charArray, 9));
            Console.ReadLine();

        }

        public static string URL(char[] str, int length)
        {
            int index =0, spaceCount = 0;
            for(int i =0; i< length; i++)
            {
                if(str[i]==' ')
                {
                    spaceCount++;
                }
            }
            index = length + 2 * spaceCount;
            if (str.Length < length) { str[str.Length] = '\0'; }
            for(int i =length -1; i>0; i--)
            {
                if(str[i]==' ')
                {
                    str[index - 1] = '0';
                    str[index - 2] = '2';
                    str[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    str[index - 1] = str[i];
                    index--;
                }
            }
            string newString = new string(str);
            return newString;
        }


        public static bool IsPalindromePermutation(string word)
        {
            int[] wordCount =new int[128];
            for(int i=0; i<word.Length; i++)
            {

            }
            return false;
        }
    }
}
