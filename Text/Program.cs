using System;

namespace Text
{
    class Program
    {
        static string[] SeporatorsText(string text)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
        /// <summary>
        /// Поиск самого маленького слова в тексте
        /// </summary>
        /// <param name="n"></Текст>
        static string MinWord(string n)
        {
            string[] words = SeporatorsText(n);
            
            int minlen = int.MaxValue,
                minIndex = 0,
                len;
            for (int i = 0; i < words.Length; i++)
            {
                len = words[i].Length;

                if (len < minlen)
                {
                    minlen = len;
                    minIndex = i;
                }
            }
            string minWord = words[minIndex];
            return minWord;
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
                maxIndex,
                len;
            for (int i = 0; i < words.Length; i++)
            {
                len = words[i].Length;
                if (len > maxlen)
                {
                    maxlen = len;
                    maxIndex = i;
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                len = words[i].Length;
                if (len == maxlen)
                {
                    d++;
                }
            }
            var count = new int[d];
            for (int q = 0; q < words.Length; q++)
            {
                if (words[q].Length == maxlen)
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
      
        static void Main(string[] args)
        {
            Console.WriteLine(MinWord("sdsfa sdfa sfa sfas fs fs f as  f sf"));
            
            Console.WriteLine(MaxWord("sdsfa sdfaf sfa sfas fs fs f as  f sf"));
        }
    }
}

