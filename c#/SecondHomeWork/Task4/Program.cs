using System;

namespace Task4
{
    class Program
    {
        // Беляев
        // Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
        // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше
        // или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
        
        static bool isValidInfo(string login, string password)
        {
            return login == "root" && password == "GeekBrains";
        }
        static void Main(string[] args)
        {
            int attemptsNumber = 3;
            do
            {
                Console.WriteLine("Enter login");
                string login = Console.ReadLine();

                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                if (isValidInfo(login, password))
                {
                    break;
                }

                attemptsNumber--;
                Console.WriteLine("Incorrect data entered, you have {0} attempts left", attemptsNumber);
            } while (attemptsNumber > 0);
        }
    }
}
