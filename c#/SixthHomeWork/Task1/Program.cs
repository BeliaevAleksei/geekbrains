using System;

namespace Task1
{
    // Беляев
    // Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    // Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
    public delegate double Fun(double a, double x);
    class Program
    { 
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        static void Main()
        {
            Table(new Fun(MyFunc), 2, -2, 2);   
            Table(MyFunc, 2, -2, 2);
            Table(delegate (double a, double x) { return a * Math.Sin(x); }, 1, 0, 3);
        }
    }
}
