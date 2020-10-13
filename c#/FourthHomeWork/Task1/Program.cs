using System;

namespace Task1
{
    //  Беляев
    //  Дан  целочисленный массив  из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
    //  Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
    //  В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

    class Program
    {
        public static int[] GetRandomArray(int length)
        {
            int[] output = new int[length];

            for (int i = 0; i < length; i++)
            {
                Random rnd = new Random();
                output[i] = rnd.Next(-10000, 10000);
            }
            return output;
        }

        public static int GetTaskValue(int[] input)
        {
            int output = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] % 3 == 0 && input[i + 1] % 3 != 0 || input[i] % 3 != 0 && input[i + 1] % 3 == 0)
                {
                    output++;
                }
            }

            return output;
        }
        static void Main(string[] args)
        {
            int[] randomAr = GetRandomArray(10);
            int output = GetTaskValue(randomAr);
            Console.WriteLine(output);
        }
    }
}
