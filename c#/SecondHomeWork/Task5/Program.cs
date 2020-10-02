using System;

namespace Task5
{
    class Program
    {
        // Беляев
        // а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
        // нужно ли человеку похудеть, набрать вес или все в норме;
        // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса
        static double getUserInputNumber(string userMessage)
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

        static double getBMIIndex(double height, double weight)
        {
            double BMI = weight / (height * height);
            return BMI * 10000;
        }
        static void printResult(double index)
        {
            if (index <= 18.5)
                Console.WriteLine("You are underweight");
            if (index >= 18.5 && index <= 24.9)
                Console.WriteLine("Your weight is normal");
            if (index >= 25.0 && index <= 29.9)
                Console.WriteLine("You are overweight");
            if (index >= 30.0 && index <= 34.9)
                Console.WriteLine("You are obese 1st degree");
            if (index >= 35.0 && index <= 39.9)
                Console.WriteLine("You have grade 2 obesity");
            if (index == 40 || index >= 40)
                Console.WriteLine("You are obese in the 3rd degree");
        }

        static double getWeightToNormal(double index, double height)
        {
            double indexToNormal = 0;
            double weightToNormal = 0;

            if (index <= 18.5)
            {
                indexToNormal = 18.5 - index;
            }
            if (index > 24.9)
            {
                indexToNormal =  24.9 - index;
            }

            if (indexToNormal != 0)
            {
                weightToNormal = (indexToNormal / 10000) * height * height;
            }

            return weightToNormal;
        }

        static void printАdvice(double index)
        {
            if (index < 0)
            {
                Console.WriteLine($"Need to decrease weight by: {index * (-1)}");
            }
            else
            {
                Console.WriteLine($"Need to increase weight by: {index}");
            }
        }
        static void Main(string[] args)
        {
            double height = getUserInputNumber("Enter your height");
            double weight = getUserInputNumber("Enter your weight");
            double index = getBMIIndex(height, weight);

            // a
            printResult(index);

            // b
            double indexToNormal = getWeightToNormal(index, height);
            printАdvice(indexToNormal);
        }
    }
}
