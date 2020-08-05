using System;

namespace InputExp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int [] luckyNumbers = new int[5];
            string [] friends = new string[5];

            for (int i = 0;  i < 5; i++)
            {
                Console.WriteLine("Enter Friend Name:");
                friends[i] = Console.ReadLine();
                Console.WriteLine("Enter Age:"); 
                luckyNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine(friends[i] + " is " + luckyNumbers[i]);
                OldEnough(luckyNumbers[i]);
            }
        }

        static void OldEnough(int age1)
        {
            if (age1 >= 21)
            {
                Console.WriteLine("You are old enough to drink.");
            }
            else
            {
                Console.WriteLine("You are underage.");
            }
        }
    }
}
