using System;
using System;
using System.IO; // Обязательно еще одно пространство имен.

namespace Task2
{
    //  Беляев
    //  Реализуйте задачу 1 в виде статического класса StaticClass;
    //  а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //  б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    //  в) ** Добавьте обработку ситуации отсутствия файла на диске.
    class StaticClass
    {
        public static int[] ReadFile(string filePath)
        {
            int[] output = new int[0];
            try
            {
                StreamReader sr = new StreamReader(filePath);
                string s = sr.ReadLine();
                string[] inputArray = s.Split(" ");
                output = new int[inputArray.Length];
                for (int i = 0; i < inputArray.Length; i++)
                {
                    int parsedInt = int.Parse(inputArray[i]);
                    output[i] = parsedInt;
                }
                sr.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            return output;
        }
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = StaticClass.ReadFile("..\\..\\data.txt");
            Console.WriteLine(StaticClass.GetTaskValue(myArray));
        }
    }
}
