using System;

namespace TwoDimExp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //This program defines the size of a matrix from user input of X and Y dimensions.
            //User is then prompted to enter an integer as data for each 'cell' - x/y location.
            //Program then displays the contents of all cells in sequential order.

            //below is the code that gets the dimension of the array
            Console.Write("Enter X Value of Matrix:");
            int xValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Y Value of Matrix:");
            int yValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //here array is defined based on user input
            int[,] array = new int[xValue, yValue];

            //due to nature of loops utilized and test conditions, the following situation of variables must occur
            int MaxValueOfXLimit = xValue - 1, MaxValueOfYLimit = yValue - 1;


            //this for loop reads the data from user into array
            for (int index1 = 0; index1 <= MaxValueOfXLimit; index1++)
            {
                for (int index2 = 0; index2 <= MaxValueOfYLimit; index2++)
                {
                    Console.WriteLine("Enter Data for array [" + index1 + "][" + index2 + "]: ");
                    array[index1, index2] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //this for loop prints out the data of array in sequential order
            for (int index1 = 0; index1 <= MaxValueOfXLimit; index1++)
            {
                for (int index2 = 0; index2 <= MaxValueOfYLimit; index2++)
                {
                    Console.WriteLine("Array [" + index1 + "][" + index2 + "] : " + array[index1, index2]);
                }
            }
        }
    }
}