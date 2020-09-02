using System;

namespace Text
{
    class Program
    {
        /// <summary>
        /// Метот разбивки строки на слова 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SeporatorsText(string text)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
        /// <summary>
        /// формирование масива, заполнение масива нужными словами
        /// </summary>
        /// <param name="razmer"></размер массива>
        /// <param name="len"></param>
        /// <param name="minlen"></param>
        /// <returns></returns>
        static string[] collect(int razmer, int minlen, string[] words)
        {
            int d = 0;
            int c = 0;
            int len;
            //string[] words = new string[razmer]; 
            for (int i = 0; i < razmer; i++)
            {
                len = words[i].Length;
                if (len == minlen)
                {
                    d++;
                }
            }
            var count = new int[d];
            for (int q = 0; q < razmer; q++)
            {
                if (words[q].Length == minlen)
                {
                    count[c] = q;
                    c++;
                }

            }
            string[] word = new string[count.Length];
            for (int i = 0; i < count.Length; i++)
            {
                int a = count[i];
                word[i] = words[a];
            }
            return word;
        }

        /// <summary>
        /// Поиск самого маленького слова в тексте
        /// </summary>
        /// <param name="n"></Текст>
        static string[] MinWord(string n)
        {
            string[] words = SeporatorsText(n);
            int minlen = int.MaxValue,
                len,
                razmer = words.Length;
            for (int i = 0; i < razmer; i++)
            {
                len = words[i].Length;
                if (len < minlen)
                {
                    minlen = len;
                }
            }
            words = collect(razmer, minlen, words);
            
            return words;
        }
        /// <summary>
        /// Поиск самых больших слов в тексте
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static string[] MaxWord(string n)
        {
            string[] words = SeporatorsText(n);
            int d = 0;
            int c = 0;
            int maxlen = int.MinValue,
                len,
                razmer = words.Length;
            for (int i = 0; i < razmer; i++)
            {
                len = words[i].Length;
                if (len > maxlen)
                {
                    maxlen = len;
                }
            }
            words = collect(razmer, maxlen, words);
            return words;
        }
      
        static void Main(string[] args)
        {
            string[] minWord = (MinWord("sdsfa sdfa sfa sfas fs fs f as  f sf"));
            
            string[] maxWord = MaxWord("sdsfa sdfaf sfa sfas fs fs f as  f sf");
            foreach (var i in maxWord)
            {
                Console.Write($"{i} ");
            }

        }
    }
}

