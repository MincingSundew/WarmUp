using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int checkPairs(int[] socks)
    {
        Hashtable ht = new Hashtable();
        for (int i = 0; i < socks.Length; i++)
        {
            if (ht.ContainsKey(socks[i]))
            {
                int value = (int)ht[socks[i]];
                ht[socks[i]] = value + 1;
            }
            else
            {
                ht.Add(socks[i], 1);
            }
        }
        int count = 0;
        for (int i = 0; i < ht.Count; i++)
        {

            if ((int)ht[socks[i]] / 2 > 0)
            {
                int current = (int)ht[socks[i]] / 2;
                count = count + current;
            }
        }

        return count;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp, Int32.Parse);
        checkPairs(c);
    }
}
