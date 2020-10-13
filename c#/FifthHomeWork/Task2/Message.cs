using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Message
    {
        string message;

        public Message(string message)
        {
            this.message = message;
        }
        public string printMessageWithLengthLess(int countSymbols)
        {
            string[] words = message.Split(' ');
            string output = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= countSymbols)
                {
                    output = output + " " + words[i];
                }
            }

            return output;
        }

        public void removeWordsWithEnd(char symb)
        {
            string[] words = message.Split(' ');
            string output = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].EndsWith(symb))
                {
                    continue;
                }

                output = output + " " + words[i];
            }

            message = output;
        }

        public string getMaxWord()
        {
            string[] words = message.Split(' ');
            string output = "";

            if (words.Length > 0)
            {
                output = words[0];

                for (int i = 1; i < words.Length; i++)
                {
                    if (words[i].Length > output.Length)
                    {
                        output = words[i];
                    }
                }
            }

            return output;
        }

        public string getMaxWords()
        {
            string output = "";
            string maxWord = getMaxWord();
            StringBuilder sbmessage = new StringBuilder(message);
            StringBuilder word = new StringBuilder();

            for (int i = 0; i < sbmessage.Length; ++i)
            {
                if (sbmessage[i] == ' ')
                {
                    if (word.Equals(maxWord))
                    {
                        output = output + " " + word.ToString();
                    }
                    word.Clear();
                    continue;
                }

                word.Append(sbmessage[i]);
            }

            return output;
        }

        public override string ToString()
        {
            return message;
        }
    }
}
