using System;

namespace Akerman
{
    class Program
    {

        // *Задание 5
        // Вычислить, используя рекурсию, функцию Аккермана:
        // A(2, 5), A(1, 2)
        // A(n, m) = m + 1, если n = 0,
        //         = A(n - 1, 1), если n <> 0, m = 0,
        //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
        /// <summary>
        /// Функция Аккермана
        /// </summary>
        /// <param name="n"></первое число>
        /// <param name="m"></второе число>
        /// <returns></returns>
        static int Ack(int n, int m)
        {
            if (n == 0)
            {
                return m + 1;
            }
            else if (n != 0 & m == 0)
            {
                return Ack(n - 1, 1);
            }
            else
            {
                return Ack(n - 1, Ack(n, m - 1));
            }

        }
        static void Main(string[] args)
        {
            int akerman = Ack(2,5);
            Console.WriteLine(akerman);
        }
    }
}
