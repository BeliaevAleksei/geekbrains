using System;
using System.Collections.Generic;

namespace FirstHomeWork
{
    class Coordinate
    {
        double x;
        double y;

        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getDistanceTo(Coordinate coordinate)
        {
            return Math.Sqrt(Math.Pow(coordinate.x - this.x, 2) + Math.Pow(coordinate.y - this.y, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            // Беляев
            // Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            // а) используя склеивание;
            // б) используя форматированный вывод;
            // в) используя вывод со знаком $.

            //Dictionary<string, string> questionnaire = new Dictionary<string, string>
            //{
            //    {"Enter your first name", ""},
            //    {"Enter your second name", ""},
            //    {"Enter your age", ""},
            //    {"Enter your height", ""},
            //    {"Enter your weight", ""},
            //};

            //var keys = new List<string>(questionnaire.Keys);

            //foreach (string key in keys)
            //{
            //    Console.WriteLine(key);
            //    questionnaire[key] = Console.ReadLine();
            //}

            //string outputConcatenation = "";
            //string outputFormated = "";
            //string outputWIthDollar = "";
            //foreach (var question in questionnaire)
            //{
            //    outputConcatenation = outputConcatenation + question.Key + ": " + question.Value + " ";
            //    outputFormated = outputFormated + string.Format("{0}: {1} ", question.Key, question.Value);
            //    outputWIthDollar = outputWIthDollar + ($"{question.Key}: {question.Value} ");
            //}

            //Console.WriteLine(outputConcatenation + "\n");
            //Console.WriteLine(outputFormated + "\n");
            //Console.WriteLine(outputWIthDollar + "\n");

            #endregion

            #region Task 2
            // Беляев
            // Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

            //double getUserInputNumber(string userMessage)
            //{
            //    bool repeat = true;
            //    double inputNumber = 0;

            //    while (repeat)
            //    {
            //        try
            //        {
            //            Console.WriteLine(userMessage);
            //            inputNumber = Convert.ToDouble(Console.ReadLine());
            //            if (inputNumber <= 0)
            //            {
            //                throw new Exception("Invalid value");
            //            }
            //            repeat = false;
            //        }
            //        catch
            //        {
            //            Console.WriteLine("Incorrect input! You should enter number > 0");
            //            repeat = true;
            //        }
            //    }

            //    return inputNumber;
            //}

            //double height = getUserInputNumber("Enter your height");
            //double weight = getUserInputNumber("Enter your weight");
            //double BMI = weight / (height * height);

            //Console.WriteLine($"Body mass index: {BMI}");
            #endregion

            #region Task 3
            // Беляев
            // а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            //      по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
            //      используя спецификатор формата .2f(с двумя знаками после запятой);
            // б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            //double x1 = 1;
            //double x2 = 2.3;
            //double y1 = 3;
            //double y2 = 3.2;

            // (a)
            //double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Console.WriteLine($"{distance:f2}");

            // (b)
            //Coordinate one = new Coordinate(x1, y1);
            //Coordinate two = new Coordinate(x2, y2);
            //double distanceFromMethod = one.getDistanceTo(two);
            //Console.WriteLine($"{distanceFromMethod:f2}");
            #endregion

            #region Task 4
            // Беляев
            // Написать программу обмена значениями двух переменных:
            // а) с использованием третьей переменной;
            // б) *без использования третьей переменной.

            //int first = 1;
            //int second = 2;
            //// (a)
            //int buffer = first;
            //first = second;
            //second = buffer;

            //// (b)
            //(first, second) = (second, first);
            #endregion

            #region Task 4
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
            #endregion
        }
    }
}
