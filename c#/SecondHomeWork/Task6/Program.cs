using System;

namespace Task6
{
    class Program
    {
        // Беляев
        // *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
        // «Хорошим» называется число, которое делится на сумму своих цифр
        // Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        static bool isGoodValue(int number)
        {
            int sum = 0, copy = number;
            while (copy != 0)
            {
                sum += copy % 10;
                copy /= 10;
            }

            return number % sum == 0;
        }
        static void Main(string[] args)
        {
            int count = 0;
            DateTime start = DateTime.Now;
            for (int i = 1; i < 1000000000; i ++)
            {
                if (isGoodValue(i))
                {
                    count++;
                }
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine(finish - start);
        }
    }
}
