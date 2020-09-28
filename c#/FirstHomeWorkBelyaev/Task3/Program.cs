using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Беляев
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
            //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
            // используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            double x1 = 1;
            double x2 = 2.3;
            double y1 = 3;
            double y2 = 3.2;

            //(a)
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"{distance:f2}");

            //(b)
            Coordinate one = new Coordinate(x1, y1);
            Coordinate two = new Coordinate(x2, y2);
            double distanceFromMethod = one.getDistanceTo(two);
            Console.WriteLine($"{distanceFromMethod:f2}");
        }
    }
}
