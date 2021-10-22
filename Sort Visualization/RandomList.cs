using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort_Visualization
{
    public static class RandomList
    {
        private static Random rng = new Random();
        public static void CreateRandom(this IList<int> list,int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                list.Add(i);
            }

            int n = list.Count;
            int k, value;
            while (n > 1)
            {
                n--;
                k = rng.Next(n + 1);
                value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}