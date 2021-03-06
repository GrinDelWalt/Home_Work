﻿using System;

namespace Progresi
{
    class Program
    {
        /// <summary>
        /// последовательность
        /// </summary>
        static string Progresi(params int[] namber)
        {
            int arifme = 0;
            int geome = 0;
            string a = "Арефметическая прогресия";
            string b = "Геометрическая прогресия";
            string c = "Являеться Арефметической и Геометрической прогрессией";
            string m = "Не являеться прогресиеей";
            
            for (int i = 0; i < namber.Length - 2; i++)
            {
                double sum = namber[i] + namber[i + 2];             
                double mult = namber[i] * namber[i + 2];
              
                if (sum / 2 == namber[i + 1])
                {
                    arifme++;
                    if (mult == namber[i + 1] * namber[i + 1] && mult != 0)
                    {
                        geome++;
                    }
                }
                else if (mult == namber[i + 1] * namber[i + 1] && mult != 0)
                {
                    geome++;
                }
                else
                {
                    return m;
                }
            }
            if (namber.Length - 2 == arifme && arifme != 0)
            {
                if (namber.Length - 2 == geome && geome != 0)
                {
                    return c;
                }
                return a;
            }
            else if (namber.Length - 2 == geome && geome != 0)
            {
                return b;
            }
            else
            {
                return m;
            }
        }
        static void Main(string[] args)
        {
            string m = Progresi(1,2,4,8);
            Console.WriteLine(m);
        }
    }
}
