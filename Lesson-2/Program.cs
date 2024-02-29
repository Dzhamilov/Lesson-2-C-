using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bits bits = new Bits(3);
            bits[1] = false;

            long num = (long)bits;
            Console.WriteLine(num);
            Bits bits2 = num;
        }
    }
}
