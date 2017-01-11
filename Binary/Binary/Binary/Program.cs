using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        public static int ConverttoBinary(int baseTenInput)
        {
            int Input = baseTenInput;
            int quotient = Input;
            List<int> binary = new List<int>();
            while (quotient >= 1)
            {
                int remainder = quotient % 2;
                quotient = quotient / 2;
                binary.Add(remainder);

            }
            string Binarystr = string.Join("", binary.ToArray()); 
            string[] arr = Binarystr.Split('0');
            string longest = arr.OrderByDescending(s => s.Length).First();
            return longest.Length;
        }
        static void Main(string[] args)
        {
            int baseTenInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ConverttoBinary(baseTenInput));
            Console.ReadLine();
        }
    }
}
