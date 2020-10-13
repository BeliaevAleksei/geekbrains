using System;
using System.Text;

namespace Task1
{
    class Program
    {
        // Беляев
        // Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов,
        //  содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        //  а) без использования регулярных выражений;
        //  б) **с использованием регулярных выражений.
        static bool checkLogin(string login)
        {
            StringBuilder strAr = new StringBuilder(login);

            if (login.Length < 2 && login.Length > 9 || char.IsDigit(strAr[0]))
            {
                return false;
            }

            bool res = true;
            for (int i = 0; i < strAr.Length; i ++)
            {
                if (!char.IsDigit(strAr[i]) && !char.IsLetter(strAr[i]))
                {
                    res = false;
                }
            }

            return res;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter login");
            string inputLogin = Console.ReadLine();
            Console.WriteLine("after metho");
            bool res = checkLogin(inputLogin);
            Console.WriteLine($"{res}");
        }
    }
}
