using System;

namespace Task2
{
    class Program
    {
        // Беляев
        // Написать метод подсчета количества цифр числа.
        static int getNumberDigits(int number)
        {
            int count = 0, copy = number;
            while (copy > 0)
            {
                copy = copy / 10;
                count++;
                Console.WriteLine(copy);
            }

            return count;
        }

        static int getNumberDigitsRecursion(int number)
        {
            if (number < 1) return 0;
            return 1 + getNumberDigitsRecursion(number / 10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(getNumberDigits(106));
        }
    }
}
