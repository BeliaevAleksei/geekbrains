using System;

namespace Task1
{
    // Беляев
    // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    // б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    // в) Добавить диалог с использованием switch демонстрирующий работу класса.

    class Program
    {
        struct ComplexStruct
        {
            public double im;
            public double re;

            public void Plus(ComplexStruct x)
            {
                this.im = im + x.im;
                this.re = re + x.re;
            }

            public void Subtract(ComplexStruct x)
            {
                this.im = im - x.im;
                this.re = re - x.re;
            }

            public void Multi(ComplexStruct x)
            {
                this.im = re * x.im + im * x.re;
                this.re = re * x.re - im * x.im;
            }
            override public string ToString()
            {
                return re + "+" + im + "i";
            }
        }

        static void Main(string[] args)
        {
            // a
            ComplexStruct coplexA1;
            ComplexStruct coplexA2;
            coplexA1.im = 3;
            coplexA1.re = 4;
            coplexA2.im = 2;
            coplexA2.re = 3;
            coplexA1.Plus(coplexA2);
            Console.WriteLine(coplexA1.ToString());

            // b
            Complex coplexB1 = new Complex(3,4);
            Complex coplexB2 = new Complex(2,3);
            coplexB1.Plus(coplexB2);
            Console.WriteLine(coplexB1.ToString());

            string classString = "class";

            switch (classString)
            {
                case "class":
                    Console.WriteLine(coplexB1.ToString());
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }
    }
}
