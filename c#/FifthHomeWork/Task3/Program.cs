using System;
using System.Text;

namespace Task3
{
    // Беляев
    // *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    // Например:
    // badc являются перестановкой abcd.
    class Program
    {
        static bool IsRearrangement(string one, string two)
        {
            if (one.Length != two.Length)
            {
                return false;
            }

            string copyOne = one;
            string copyTwo = two;

            for (int i = 0; i < copyOne.Length; i++)
            {
                int index = copyTwo.IndexOf(copyOne[i]);
                if (index != -1)
                {
                    copyTwo = copyTwo.Remove(index, 1);
                    continue;
                }

                return false;
            }

            return true;

        }
        static void Main(string[] args)
        {
            string a = "badc";
            string b = "abcd";

            Console.WriteLine(IsRearrangement(a, b));
        }
    }
}
