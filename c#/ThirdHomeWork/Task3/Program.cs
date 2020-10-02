using System;

namespace Task3
{
    // Беляев
    //    * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    // Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
    //    * Добавить свойства типа int для доступа к числителю и знаменателю;
    //    * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    //    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    //    *** Добавить упрощение дробей.
    class Program
    {
        static void Main(string[] args)
        {
            Fraction myFraction = new Fraction();
            myFraction.Numerator = 1;
            myFraction.Denominator = 2;
            Fraction myFraction2 = new Fraction();
            myFraction2.Numerator = 6;
            myFraction2.Denominator = 4;

            myFraction.sum(myFraction2);
            Console.WriteLine(myFraction);

            myFraction.subtraction(myFraction2);
            Console.WriteLine(myFraction);

            myFraction.multiplication(myFraction2);
            Console.WriteLine(myFraction);

            myFraction.division(myFraction2);
            Console.WriteLine(myFraction);

            Console.WriteLine(myFraction.getDecimal());

            Console.ReadKey();
            myFraction.Denominator = 0; // Enter some value for throw error
        }
    }
}
