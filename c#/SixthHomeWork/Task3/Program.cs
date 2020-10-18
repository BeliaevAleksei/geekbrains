using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Task3
{
    // Беляев
    //  Переделать программу Пример использования коллекций для решения следующих задач:
    //  а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //  б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
    //  в) отсортировать список по возрасту студента;
    //  г) * отсортировать список по курсу и возрасту студента;
    class Program
    {
        static void Main(string[] args)
        {
            int numOfBachelors = 0;
            int numOfMasters = 0;
            int numberOfFifthCourse = 0;
            int numberOfSixthCourse = 0;
            Dictionary<string, int> listCourses = new Dictionary<string, int>();
            listCourses.Add("18", 0);
            listCourses.Add("19", 0);
            listCourses.Add("20", 0);

            // Создадим необобщенный список
            ArrayList list = new ArrayList();
            // Запомним время в начале обработки данных
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    int course = int.Parse(s[6]);
                    int age = int.Parse(s[6]);

                    if (course < 5) numOfBachelors++; else numOfMasters++;
                    if (course == 5) numberOfFifthCourse++;
                    if (course == 6) numberOfSixthCourse++;
                    if (age >= 18 && int.Parse(s[6]) <= 20)
                    {
                        listCourses[s[6]] += 1;
                    }
                }
                catch
                {
                }
            }
            sr.Close();
            list.Sort(new MyStudentClassComparer());
            Console.WriteLine("Всего студентов:{0}", list.Count);
            Console.WriteLine("Магистров:{0}", numOfMasters);
            Console.WriteLine("Бакалавров:{0}", numOfBachelors);
            foreach (var v in list) Console.WriteLine(v);

            // Вычислим время обработки данных
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();

        }
    }
}
