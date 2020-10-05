﻿using System;
using MyLibrary;

namespace Task5
{
    //  Беляев
    //  * а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами.Создать методы, которые возвращают
    //      сумму всех элементов массива,
    //      сумму всех элементов массива больше заданного,
    //      свойство, возвращающее минимальный элемент массива,
    //      свойство, возвращающее максимальный элемент массива,
    //      метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
    //  ** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    //  ** в) Обработать возможные исключительные ситуации при работе с файлами.
    class Program
    {
        static void Main(string[] args)
        {
            MyTwoDimensionalArray t = new MyTwoDimensionalArray(2, 3);
            Console.WriteLine(t.Max);
            Console.WriteLine(t.Min);
            Console.WriteLine(t.Sum());
        }
    }
}
