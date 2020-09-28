using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Беляев
            // Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            // а) используя склеивание;
            // б) используя форматированный вывод;
            // в) используя вывод со знаком $.

            Dictionary<string, string> questionnaire = new Dictionary<string, string>
            {
                {"Enter your first name", ""},
                {"Enter your second name", ""},
                {"Enter your age", ""},
                {"Enter your height", ""},
                {"Enter your weight", ""},
            };

            var keys = new List<string>(questionnaire.Keys);

            foreach (string key in keys)
            {
                Console.WriteLine(key);
                questionnaire[key] = Console.ReadLine();
            }

            string outputConcatenation = "";
            string outputFormated = "";
            string outputWIthDollar = "";
            foreach (var question in questionnaire)
            {
                outputConcatenation = outputConcatenation + question.Key + ": " + question.Value + " ";
                outputFormated = outputFormated + string.Format("{0}: {1} ", question.Key, question.Value);
                outputWIthDollar = outputWIthDollar + ($"{question.Key}: {question.Value} ");
            }

            Console.WriteLine(outputConcatenation + "\n");
            Console.WriteLine(outputFormated + "\n");
            Console.WriteLine(outputWIthDollar + "\n");
        }
    }
}
