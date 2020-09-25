using System;

namespace Task6
{
    class Program
    {
        public double getUserInputNumber(string userMessage)
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

        public void printMesage(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        public void Pause()
        {
            Console.ReadKey();
        }
    }
}
