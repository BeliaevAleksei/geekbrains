using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Беляев
            // Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

            double getUserInputNumber(string userMessage)
            {
                bool repeat = true;
                double inputNumber = 0;

                while (repeat)
                {
                    try
                    {
                        Console.WriteLine(userMessage);
                        inputNumber = Convert.ToDouble(Console.ReadLine());
                        if (inputNumber <= 0)
                        {
                            throw new Exception("Invalid value");
                        }
                        repeat = false;
                    }
                    catch
                    {
                        Console.WriteLine("Incorrect input! You should enter number > 0");
                        repeat = true;
                    }
                }

                return inputNumber;
            }

            double height = getUserInputNumber("Enter your height");
            double weight = getUserInputNumber("Enter your weight");
            double BMI = weight / (height * height);

            Console.WriteLine($"Body mass index: {BMI}");
        }
    }
}
