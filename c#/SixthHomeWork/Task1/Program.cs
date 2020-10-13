using System;

namespace Task1
{
    // Беляев
    // Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    // Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
    public delegate double Fun(double a, double x);
    class Program
    { 
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
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
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        static void Main()
        {
            Console.WriteLine("Таблица функции MyFunc:");
            Table(new Fun(MyFunc), 2, -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");     
            Table(MyFunc, 2, -2, 2);
            Console.WriteLine("Таблица функции Sin:");
            Table(delegate (double a, double x) { return a * Math.Sin(x); }, 1, 0, 3);
        }
    }
}
