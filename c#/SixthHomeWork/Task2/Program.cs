using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task2
{
    // Беляев
    // Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    // а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //    Использовать массив(или список) делегатов, в котором хранятся различные функции.
    // б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out). 
    class Program
    {
        static int getUserInputNumber(string userMessage, int minValue, int maxValue)
        {
            bool repeat = true;
            int inputNumber = 0;

            while (repeat)
            {
                try
                {
                    Console.WriteLine(userMessage);
                    inputNumber = Convert.ToInt32(Console.ReadLine());
                    if (inputNumber < minValue || inputNumber > maxValue)
                    {
                        throw new Exception("Invalid value");
                    }
                    repeat = false;
                }
                catch
                {
                    Console.WriteLine($" Incorrect input! You should enter number id diapason <{minValue}, {maxValue}>");
                    repeat = true;
                }
            }

            return inputNumber;
        }
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public delegate double MinFun(double[] ar, int startIndex, int endIndex);


        public static double MySimpleMinFunc(double[] ar, int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex > ar.Length - 1)
            {
                throw new Exception("Invalid work diapason");
            }
            double min = double.MaxValue;
            for (int i = 0; i < ar.Length ; i++)
            {
                if (ar[i] < min) min = ar[i];
            }

            return min;
        }

        public static double MyEvenMinFunc(double[] ar, int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex > ar.Length - 1)
            {
                throw new Exception("Invalid work diapason");
            }

            double min = double.MaxValue;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < min && ar[i] % 2 == 0) min = ar[i];
            }

            return min;
        }

        public static void SaveFunc(string fileName, double startValue, double maxValue, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = startValue;
            while (x <= maxValue)
            {
                bw.Write(F(x));
                x += step;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] ReadFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] inputAr = new double[0];
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                Array.Resize(ref inputAr, inputAr.Length + 1);
                d = bw.ReadDouble();
                inputAr[inputAr.Length - 1] = d;
            }
            bw.Close();
            fs.Close();

            return inputAr;
        }
        public static double[] Load(MinFun MinFunction, string fileName, int startIndex, int endIndex, out double min)
        {
            double[] inputAr = ReadFile(fileName);
            min = MinFunction(inputAr, startIndex, endIndex);

            return inputAr;
        }

        static void Main(string[] args)
        {

            double minValue;
            List<MinFun> delegates = new List<MinFun> { MySimpleMinFunc, MyEvenMinFunc };
            Dictionary<string, MinFun> delegatesDict = new Dictionary<string, MinFun>();
            delegatesDict.Add("MySimpleMinFunc", delegates[0]);
            delegatesDict.Add("MyEvenMinFunc", delegates[1]);

            Console.WriteLine("Enter one of available methods:");
            for (int i=0; i < delegatesDict.Count; i++)
            {
                Console.WriteLine($"{delegatesDict.ElementAt(i).Key} - {i}");
            }

            int indexFunction = getUserInputNumber("Enter number:", 0, delegatesDict.Count - 1);
            int startIndex = getUserInputNumber("Enter start search array index:", 0, int.MaxValue); // max value can be calculated, but I want to sleep
            int endIndex = getUserInputNumber("Enter end search array index:", 0, int.MaxValue);

            SaveFunc("data2.bin", -100, 100, 0.5);
            Load(delegatesDict.ElementAt(indexFunction).Value, "data2.bin", startIndex, endIndex,  out minValue);
            Console.WriteLine(minValue);
            Console.ReadKey();
        }
    }
}
