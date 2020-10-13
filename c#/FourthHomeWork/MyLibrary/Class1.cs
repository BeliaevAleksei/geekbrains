using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public class MyArray
    {
        int[] a;

        public MyArray(int[] array)
        {
            a = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                a[i] = array[i];
        }
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        public MyArray(int n, int startValue, int step)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = startValue + (i * step);
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 1; i < a.Length; i++)
                    sum = sum + a[i];
                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                int maxValue = a[0], countMax = 0;

                if (a.Length == 0)
                {
                    return 0;
                }
                for (int i = 1; i < a.Length; i++)
                {
                    if (maxValue == a[i])
                    {
                        countMax++;
                    }
                    if (maxValue < a[i])
                    {
                        maxValue = a[i];
                        countMax = 0;
                    }
                }

                return countMax;
            }
        }
        public void Multi(int value)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * value;
            }
        }
        public int[] Inverse()
        {
            int[] inversed = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                inversed[i] = a[i] * -1;
            }

            return inversed;
        }

        public Dictionary<int, int> GetValuesDictionary()
        {
            Dictionary<int, int> output = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (output.ContainsValue(a[i]))
                {
                    output[a[i]] = output[a[i]] + 1;
                } else
                {
                    output.Add(a[i], 1);
                }
            }

            return output;
        }
        override public string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}
