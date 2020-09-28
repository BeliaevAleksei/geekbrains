using System;

namespace Task1
{
    class Program
    {
        // Беляев
        // Написать метод, возвращающий минимальное из трёх чисел.
        static double getMax(double first, double second, double third)
        {

            if (first < second)
            {
                if (first < third)
                {
                    return first;
                }
                else
                {
                    return third;
                }
            }
            else
            {
                if (second < third)
                {
                    return second;
                }
                else
                {
                    return third;
                }
            }
        }

        static void Main(string[] args)
        {
            double a = 2, b = 3, c = 1;
            double minValue = getMax(a, b, c);

            Console.WriteLine(minValue);
        }
    }
}
