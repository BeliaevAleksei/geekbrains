using System;

namespace Task2
{
    // Беляев
    // С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
    // Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse.
    class Program
    {
        static int GetSum(string message)
        {
            int sum = 0, x;
            string inputValue;
            bool flag = false;

            do
            {
                Console.WriteLine(message);
                inputValue = Console.ReadLine();
                if (int.TryParse(inputValue, out x))
                {
                    int value = Convert.ToInt32(inputValue);
                    if (value == 0)
                    {
                        flag = true;
                    }

                    if (value > 0 && value % 2 != 0)
                    {
                        sum = sum + value;
                    }
                }
            }
            while (!flag);
            return sum;
        }

        static void Main(string[] args)
        {
            int output = GetSum("Some value");
            Console.WriteLine(output);
        }
    }
}
