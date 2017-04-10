using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class BubbleSort
{
    public int numSwaps;
    public int firstElement;
   public int lastElement;
    public BubbleSort()
    {
        numSwaps = 0;
        firstElement = 0;
        lastElement = 0;      
    }

    public int[] Sort(int n, int []a)
    {
       
        for(int i=0;i< n;i++)
        {
            for(int j=0; j<n -1; j++)
            {
                int temp = 0;
                if(a[j]>a[j+1])
                {
                    temp = a[j];                
                    a[j] = a[j + 1];
                    a[j+1] = temp;
                    numSwaps++;
                }
            }
            if(numSwaps == 0)
            {
                firstElement = a[0];
                lastElement = a[a.Length - 1];
                return a;

            }
        }
        firstElement = a[0];
        lastElement = a[n - 1];
        return a;
    }
}
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        BubbleSort sortingAlg = new BubbleSort();
        sortingAlg.Sort(n, a);
        Console.WriteLine("Array is sorted in "+ sortingAlg.numSwaps +" swaps.");
        Console.ReadLine();
        Console.WriteLine("First Element: "+sortingAlg.firstElement);
        Console.ReadLine();
        Console.WriteLine("Last Element: " + sortingAlg.lastElement);
        Console.ReadLine();
    }
}
