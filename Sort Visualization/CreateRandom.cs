using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort_Visualization
{
    public static class CreateRandom
    {
        public static void ShuffleList(List<string> list)
        {
            for(int i = 1; i <= 70; i++)
            {
                list.Add(i.ToString()); 
            }
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}