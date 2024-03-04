using System;
using System.Collections.Generic;

namespace Lesson_3
{
    internal class Program
    {
        /* Доработайте приложение поиска пути в лабиринте, но на этот раз вам нужно 
         * определить сколько всего выходов имеется в лабиринте:

            int[,] labirynth1 = new int[,]
            {
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 0, 0, 0, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {0, 0, 0, 0, 1, 0, 0 },
            {1, 1, 0, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 },
            {1, 1, 1, 0, 1, 1, 1 }
            };

            Сигнатура метода:

            static int HasExit(int startI, int startJ, int[,] l)
        */
        static void Main(string[] args)
        {
           
            int[,] labirynth1 = new int[,]
        {
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 0, 0, 2, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {0, 0, 0, 0, 1, 0, 2 },
            {1, 1, 0, 2, 1, 1, 1 },
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 1, 1, 1, 1, 1, 1 }
        };
            Console.WriteLine($"Количество выходов= {Labirinth.HasExit(1, 1, labirynth1)}");

        }
    }
}
