using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SoftwareTest
{
    /**
     * Welcome to the Software Test. Please make sure you
     * read the instructions carefully.
     *
     * FAQ:
     * Can I use linq? Yes.
     * Can I cheat and look things up on Stack Overflow? Yes.
     * Can I use a database? No.
     */

    /// There are two challenges in this file
    /// The first one should takes ~10 mins with the
    /// second taking between ~30-40 mins.
    public interface IChallenge
    {
        /// Are you a winner?
        bool Winner();
    }

    /// Lets find out
    public class Program
    {
        /// <summary>
        /// Challenge Uno - NumberCalculator
        ///
        /// Fill out the TODOs with your own code and make any
        /// other appropriate improvements to this class.
        /// </summary>
        public class NumberCalculator : IChallenge
        {
            public int FindMax(int[] numbers)
            {
                // TODO: Find the highest number

                if (numbers.Length <= 0)
                {
                    throw new ArgumentException("Please enter non empty array", "maxLength");
                }
                int maxNumber;
                maxNumber = numbers.Max();
                return maxNumber;
            }

            public int[] FindMax(int[] numbers, int n)
            {
                // TODO: Find the 'n' highest numbers
                if (numbers.Length <= 0 || n <= 0)
                {
                    throw new ArgumentException("Please enter non empty array", "maxLength");
                }
                // TODO: Find the 'n' highest numbers
                var result = numbers.OrderByDescending(x => x).Take(n);
                return result.ToArray();

            }

            public int[] Sort(int[] numbers)
            {
                // TODO: Sort the numbers

                if (numbers.Length <= 0)
                {
                    throw new ArgumentException("Please enter non empty array", "maxLength");
                }
                // TODO: Sort the numbers
                Array.Sort(numbers);
                return numbers;
            }

            public bool Winner()
            {
                var numbers = new[] { 5, 7, 5, 3, 6, 7, 9 };
                var sorted = Sort(numbers);
                var maxes = FindMax(numbers, 2);

                // TODO: Are the following test cases sufficient, to prove your code works
                // as expected? If not either write more test cases and/or describe what
                // other tests cases would be needed.

                return sorted.First() == 3
                       && sorted.Last() == 9
                       && FindMax(numbers) == 9
                       && maxes[0] == 9
                       && maxes[1] == 7;
            }
        }

        /// <summary>
        /// Challenge Due - Run Length Encoding
        ///
        /// RLE is a simple compression scheme that encodes runs of data into
        /// a single data value and a count. It's useful for data that has lots
        /// of contiguous values (for example it was used in fax machines), but
        /// also has lots of downsides.
        ///
        /// For example, aaaaaaabbbbccccddddd would be encoded as
        ///
        /// 7a4b4c5d
        ///
        /// You can find out more about RLE here...
        /// http://en.wikipedia.org/wiki/Run-length_encoding
        ///
        /// In this exercise you will need to write an RLE **Encoder** which will take
        /// a byte array and return an RLE encoded byte array.
        /// </summary>
        public class RunLengthEncodingChallenge : IChallenge
        {


            public  byte[] Encode(byte[] source)
            {
                List<byte> dest = new List<byte>();
                byte runLength;

                for (int i = 0; i < source.Length; i++)
                {
                    runLength = 1;
                    while (runLength < byte.MaxValue
                        && i + 1 < source.Length
                        && source[i] == source[i + 1])
                    {
                        runLength++;
                        i++;
                    }
                    dest.Add(runLength);
                    dest.Add(source[i]);
                }

                return dest.ToArray();
            }






            public bool Winner()
            {
                // TODO: Are the following test cases sufficient, to prove your code works
                // as expected? If not either write more test cases and/or describe what
                // other tests cases would be needed.

                var testCases = new[]
                {
                    new Tuple<byte[], byte[]>(new byte[]{0x01, 0x02, 0x03, 0x04}, new byte[]{0x01, 0x01, 0x01, 0x02, 0x01, 0x03, 0x01, 0x04}),
                    new Tuple<byte[], byte[]>(new byte[]{0x01, 0x01, 0x01, 0x01}, new byte[]{0x04, 0x01}),
                    new Tuple<byte[], byte[]>(new byte[]{0x01, 0x01, 0x02, 0x02}, new byte[]{0x02, 0x01, 0x02, 0x02})
                };

                // TODO: What limitations does your algorithm have (if any)?
                // TODO: What do you think about the efficiency of this algorithm for encoding data?

                foreach (var testCase in testCases)
                {
                    var encoded = Encode(testCase.Item1);
                    var isCorrect = encoded.SequenceEqual(testCase.Item2);

                    if (!isCorrect)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public static void Main(string[] args)
        {
            var challenges = new IChallenge[]
            {
                new NumberCalculator(),
                new RunLengthEncodingChallenge()
            };

            foreach (var challenge in challenges)
            {
                var challengeName = challenge.GetType().Name;

                var result = challenge.Winner()
                    ? string.Format("You win at challenge {0}", challengeName)
                    : string.Format("You lose at challenge {0}", challengeName);

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
