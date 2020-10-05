using System;
using System.IO;

namespace Task4
{
    // Беляев
    // Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
    class Account
    {
        string login;
        string password;

        public Account(string log, string pas)
        {
            login = log;
            password = pas;
        }

        public bool isValid()
        {
            return login == "root" && password == "GeekBrains";
        }
    }
    class Program
    {
        public static string[] ReadFile(string filePath)
        {
            string[] output = new string[0];

            try
            {
                StreamReader sr = new StreamReader(filePath);
                string s = sr.ReadLine();
                output = s.Split(" ");
                sr.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            return output;
        }
        static void Main(string[] args)
        {
            string[] input = ReadFile("..\\..\\data.txt");
            Account myAc = new Account(input[0], input[1]);
            Console.WriteLine(myAc.isValid());
        }
    }
}
