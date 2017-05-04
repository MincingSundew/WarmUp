using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLogic
{
    class Program
    {
        public static void calculateFine(DateTime returnDate, DateTime dueDate)
        {
            int fine = 0;
            if ((returnDate - dueDate).Days <= 0)
            {
                fine = 0;
                Console.WriteLine(fine);
                Console.ReadLine();
            }
            else
            {
                if (dueDate.Year == returnDate.Year && dueDate.Month == returnDate.Month && returnDate.Day > dueDate.Day)

                {
                    fine = 15 * (returnDate.Day - dueDate.Day);
                    Console.WriteLine(fine);
                    Console.ReadLine();
                }

                else if (dueDate.Year == returnDate.Year && returnDate.Month > dueDate.Month)
                {
                    fine = 500 * (returnDate.Month - dueDate.Month);
                    Console.WriteLine(fine);
                    Console.ReadLine();
                }
                else if (returnDate.Year > dueDate.Year)
                {
                    fine = 10000;
                    Console.WriteLine(fine);
                    Console.ReadLine();
                }
            }
        }

        static void Main(string[] args)
        {
            string[] returnDate = Console.ReadLine().Split(' ');
            DateTime retDate = Convert.ToDateTime(returnDate[1] + "/" + returnDate[0] + "/" + returnDate[2]);
            string[] dueDate = Console.ReadLine().Split(' ');
            DateTime dDate = Convert.ToDateTime(dueDate[1]+"/"+dueDate[0]+"/"+dueDate[2]);

            calculateFine(retDate, dDate);
        }
    }
}
