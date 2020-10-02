using System;

namespace Task7
{
    class Program
    {
        // Беляев
        // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
        // б) Разработать рекурсивный метод, который считает сумму чисел от a до b.

        static void printValueInDiapason(int start, int end)
        {
            if (start == end)
            {
                return;
            }

            Console.WriteLine(start);
            printValueInDiapason(start + 1, end);
        }

        static int getSumInDiapason(int start, int end)
        {
            if (start == end)
            {
                return 0;
            }

            
            return start + getSumInDiapason(start + 1, end);
        }
        static void Main(string[] args)
        {
            // a
            printValueInDiapason(10, 15);

            // b
            Console.WriteLine(getSumInDiapason(1, 4));
        }
    }
}
