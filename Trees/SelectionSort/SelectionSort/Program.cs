using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        public static  int findSmallest(List<int> arr)
        {
            int smallest = arr[0];
            for(int i=0; i< arr.Count; i++)
            {
                if(arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            return smallest;
        }

        public static List<int>   selectionSort(List<int> arr)
        {
            int arrLength = arr.Count;
            List<int> sortedArray = new List<int>();
            int i = arr.Count;
            while(i >0 )
            {
              int smallest = findSmallest(arr);
                sortedArray.Add(smallest);
                arr.Remove(smallest);
                i--;
            }
            return sortedArray;
        }

        public static int[] BubbleSort(int[] arr)
        {
            for(int i =0; i< arr.Length; i++)
            {
                for(int j = 0; j< arr.Length - 1; j++)
                {
                    if(arr[i] <  arr[j])
                    {
                        int temp = 0;
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }


        public static List<int> quickSort(List<int> arr)
        {
            if(arr.Count < 2)
            {
                return arr;
            }

            else
            {
                int pivot = arr[0];
                List<int> less = arr.Where(x => x < pivot).ToList();
                List<int> more = arr.Where(x => x > pivot).ToList();
                var result = new List<int>();
                result.AddRange(quickSort(less));
                result.Add(pivot);
                result.AddRange(quickSort(more));
                return result;

            }

        }

        static void Main(string[] args)
        {
            List<int> testSS = new List<int>();
            testSS.Add(7);
            testSS.Add(3);
            testSS.Add(9);
            testSS.Add(2);

            testSS.Add(5);
            int[] s = testSS.ToArray();
          int[] tt = BubbleSort(s);

            foreach(int i in tt)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }


        }
    }
}
