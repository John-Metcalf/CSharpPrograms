using System;

namespace MysteryBook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 1;
            int total = 0;

            while (x <= 11)
            {
                int y = x * x;
                Console.WriteLine(y);
                total += y;
                ++x;
            }
            Console.WriteLine($"Total is {total}");
        }
    }
}
