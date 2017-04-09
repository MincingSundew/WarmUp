//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;

//namespace SoftwareTest
//{
//    /**
//     * Welcome to the Software Test. Please make sure you
//     * read the instructions carefully.
//     *
//     * FAQ:
//     * Can I use linq? Yes.
//     * Can I cheat and look things up on Stack Overflow? Yes.
//     * Can I use a database? No.
//     */

//    /// There are two challenges in this file
//    /// The first one should takes ~10 mins with the
//    /// second taking between ~30-40 mins.


//    public class NumberCalculator
//    {
//        public int FindMax(int[] numbers)
//        {
//            if (numbers.Length <= 0)
//            {
//                throw new ArgumentException("Please enter non empty array", "maxLength");
//            }
//            int maxNumber;
//            maxNumber = numbers.Max();
//            return maxNumber;
//        }

//        public int[] FindMax(int[] numbers, int n)
//        {
//            if (numbers.Length <= 0 || n <= 0)
//            {
//                throw new ArgumentException("Please enter non empty array", "maxLength");
//            }
//            // TODO: Find the 'n' highest numbers
//            var result = numbers.OrderByDescending(x => x).Take(n);
//            return result.ToArray();
//        }

//        public int[] Sort(int[] numbers)
//        {
//            if (numbers.Length <= 0)
//            {
//                throw new ArgumentException("Please enter non empty array", "maxLength");
//            }
//            // TODO: Sort the numbers
//            Array.Sort(numbers);
//            return numbers;
//        }
//    }


//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            //RunLengthEncodingChallenge sut = new RunLengthEncodingChallenge();
//            //string input = "aaaaaaabbbbccccddddd";
//            //byte[] array1 = Encoding.ASCII.GetBytes(input);

//            //string str = System.Text.Encoding.Default.GetString(array1);


//            //Console.WriteLine(str);
//            //Console.ReadLine();
//        }
//    }


//}
