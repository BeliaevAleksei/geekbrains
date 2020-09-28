using System;

namespace Task3
{
    class Program
    {
        // Беляев
        // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Main(string[] args)
        {
            bool repeat = true;
            int sum = 0;

            while (repeat)
            {
                try
                {
                    Console.WriteLine("Enter number");
                    int inputNumber = Convert.ToInt32(Console.ReadLine());

                    if (inputNumber > 0 && inputNumber % 2 != 0)
                    {
                        sum = sum + inputNumber;
                    }

                    if (inputNumber == 0)
                    {
                        repeat = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect input! You should enter integer");
                    repeat = true;
                }
            }

            Console.WriteLine("Total sum of all odd positive numbers {0}", sum);
        }
    }
}
