using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Беляев
            // Написать программу обмена значениями двух переменных:
            // а) с использованием третьей переменной;
            // б) *без использования третьей переменной.

            int first = 1;
            int second = 2;
            // (a)
            int buffer = first;
            first = second;
            second = buffer;

            // (b)
            (first, second) = (second, first);
        }
    }
}
