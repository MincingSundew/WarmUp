using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteDifference
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public Difference(int[] elements)
        {
            this.elements = elements;
        }
        public int computeDifference()
        {
            int MaximumNumber = 0;
            int MinimumNumber = 0;
            for(int i=0;i<= maximumDifference-1; i++)
            {
                if(elements[i] > MaximumNumber)
                {
                    MaximumNumber = elements[i];
                }
                if (elements[i] < MinimumNumber)
                {
                    MinimumNumber = elements[i];
                }

                maximumDifference = MaximumNumber - MinimumNumber;
            }
            return maximumDifference;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
