using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    internal class Labirinth
    {
        public static int HasExit(int startI, int startJ, int[,] labirinth)
        {
            Queue<(int, int)> coords = new();
            int count = 0;
            if (labirinth[startI, startJ] != 1)
            {
                coords.Enqueue((startI, startJ));
            }
            while (coords.Count > 0)
            {


                (int i, int j) = coords.Dequeue();
                if (labirinth[i, j] == 2)
                    count++;


                labirinth[i, j] = 1;
                if (i - 1 >= 0 && labirinth[i - 1, j] != 1) coords.Enqueue((i - 1, j));
                if (i + 1 < labirinth.GetLength(0) && labirinth[i + 1, j] != 1) coords.Enqueue((i + 1, j));
                if (j - 1 >= 0 && labirinth[i, j - 1] != 1) coords.Enqueue((i, j - 1));
                if (j + 1 < labirinth.GetLength(1) && labirinth[i, j + 1] != 1) coords.Enqueue((i, j + 1));
            }
            return count;
        }
    }
}
