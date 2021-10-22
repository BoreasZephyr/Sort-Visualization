using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAl
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 49,42,57,86,96,82,55,6,74,34,64,7,48,11,58,21,54,21,99,81};
            InsertionSort(ref a, a.Length-1);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

        }

        static void BubbleSort(ref int[] a, int n)
        {
            bool swap;
            do
            {
                swap = false;
                n--;
                for (int i = 0; i < n; i++)
                {
                    if (a[i + 1] < a[i])
                    {
                        int t = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = t;
                        swap = true;
                    }

                }
            }
            while (swap);
        }

        static void SlectionSort(ref int[] a, int n)
        {
            int pos = 0, content = 0;
            for (int i = 0; i < n - 1; i++)
            {
                content = a[i];
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < content)
                    {
                        content = a[j];
                        pos = j;
                    }
                }
                int t = a[pos];
                a[pos] = a[i];
                a[i] = t;
            }
        }

        static void Insert(ref int[] a, int from, int to)
        {
            int value = a[from];
            for (int i = from; i > to; i--)
            {
                a[i] = a[i - 1];
            }
            a[to] = value;
        }
        static void InsertionSort(ref int[] a, int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                t = i;
                if (a[i] < a[i - 1])
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (a[i] > a[j])
                        {
                            break;
                        }
                        t = j;
                    }
                }
                Insert(ref a, i, t);
            }
        }
    }
}
