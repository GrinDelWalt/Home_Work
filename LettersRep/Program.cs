using System;

namespace LettersRep
{
    class Program
    {
        /// <summary>
        /// Удаление повторов
        /// </summary>
        /// <param name="n"></Текст>
        static string Words(string n)
        {
            char[] word = n.ToCharArray();

            var tempWord = new char[word.Length];
            int c = 0;
            string bigLetter;
            string litlLetter;
            word.ToString();
            for (int i = 0; i < word.Length - 1; i++)
            {
                litlLetter = bigLetter = word[i].ToString();
                bigLetter = bigLetter.ToLower();
                litlLetter = litlLetter.ToUpper();
                if (bigLetter == word[i + 1].ToString())
                {
                    continue;
                }
                else if (litlLetter == word[i + 1].ToString())
                {
                    continue;
                }
                else
                {
                    tempWord[c] = word[i];
                    c++;
                }
               
               

            }
            tempWord[c] = word[word.Length - 1];
            
            string newStr = String.Join("", tempWord);
            
            return newStr;
        }
        static void Main(string[] args)
        {
            string words = Words("хххХхХхХхХоооорррооошшшиий деееннннь");
            Console.Write(words);
            
        }
    }
}
