using System;

namespace TriangleProgram
{
    class QuadrantProcessValues
    {
        public int UserInput { get; set; }
        public QuadrantProcessValues(int user_input, int user_width_choice)
        {
            UserInput = user_input;
            if (UserInput == 1)
            {
                for (int i = 0; i < user_width_choice; ++i)
                {
                    for (int j = 0; j <= i; ++j)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (UserInput == 2)
            {
                int j = user_width_choice;
                int l = 0;
                for (int i = 0; i <= user_width_choice; ++i)
                {
                    do
                    {
                        if (l < j)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                        ++l;
                    } while (l < user_width_choice);
                    --j;
                    l = 0;
                    Console.WriteLine();
                }

            }
            else if (UserInput == 3)
            {
                for (int i = 0; i < user_width_choice; ++i)
                {
                    int j = 0;
                    do
                    {
                        if (j < i)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                        ++j;
                    } while (j < user_width_choice);
                    Console.WriteLine();
                }

            }
            else if (UserInput == 4)
            {
                for (int i = user_width_choice; i > 0; --i)
                {
                    for (int j = 0; j < i; ++j)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {

            //Was hoping to use exception handling for testing values - this only works with integers

            Console.Write("Enter value of quadrant for triangle(1,2,3,4):");
            int number1 = 1;
            do {
                number1 = int.Parse(Console.ReadLine());
                if(number1 < 1 | number1 > 4){
                    Console.WriteLine("Error. Enter value between 1 and 4");
                }
            }while (number1 < 1 | number1 > 4);


            Console.Write("Enter Max width of triangle (1-50): ");
            int Width_Entry = 1;
            do
            {
                Width_Entry = int.Parse(Console.ReadLine());
                if (Width_Entry < 1 | Width_Entry > 50)
                {
                    Console.WriteLine("Error. Enter value between 1 and 50");
                }
            } while (Width_Entry < 1 | Width_Entry > 50);


            QuadrantProcessValues UserProcess1 = new QuadrantProcessValues(number1, Width_Entry);
        }
    }
}
