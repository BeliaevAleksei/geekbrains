using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class MyTwoDimensionalArray
    {
        int[][] a;

        public MyTwoDimensionalArray(int n, int m)
        {
            a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[m];
            }
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i][j] = rnd.Next(1, 12);
                    Console.WriteLine(a[i][j]);
                }
            }
        }

        public int Max
        {
            get
            {
                int max = a[0][0];
                foreach (int[] row in a)
                {
                    foreach (int number in row)
                    {
                        if (number > max) max = number;
                    }
                }
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0][0];
                foreach (int[] row in a)
                {
                    foreach (int number in row)
                    {
                        if (number < min) min = number;
                    }
                }
                return min;
            }
        }
        public int Sum()
        {
            int sum = 0;
            foreach (int[] row in a)
            {
                foreach (int number in row)
                {
                    sum = sum + number;
                }
            }

            return sum;
        }

        public ref int GetMaxValueRef()
        {
            int max = a[0][0];
            ref int reference = ref a[0][0];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] > max)
                    {
                        max = a[i][j];
                        reference = ref a[i][j];
                    }
                }
            }

            return ref reference;
        }
        public int SumMoreThan(int value)
        {
            int sum = 0;
            foreach (int[] row in a)
            {
                foreach (int number in row)
                {
                    if (number > value)
                    {
                        sum = sum + number;
                    }
                }
            }

            return sum;
        }
    }
}
