using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Беляев
            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            // б) *Сделать задание, только вывод организовать в центре экрана.
            // в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

            Dictionary<string, string> someData = new Dictionary<string, string>
            {
                {"First name", "firstName"},
                {"Second name", "secondName"},
                {"City", "City"},
            };

            string outputData = "";
            foreach (var question in someData)
            {
                outputData = outputData + ($"{question.Key}: {question.Value} ");
            }

            // (a)
            Console.WriteLine(outputData + "\n");

            // (b)
            Console.SetCursorPosition((Console.WindowWidth - outputData.Length) / 2, Console.CursorTop);
            Console.WriteLine(outputData);

            // (c)
            void printMesage(string message, int x, int y)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(message);
            }

            printMesage(outputData, (Console.WindowWidth - outputData.Length) / 2, Console.CursorTop);
        }
    }
}
