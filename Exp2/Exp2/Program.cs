using System;

namespace Exp2
{

    class ObjectInputData
    {
        public ObjectInputData(int xValue,int yValue)
        {
            //creates the size of array in object based on user input
            int[,] array = new int[xValue, yValue];
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

            //this for loop prints out the input data of array in sequential order
            for (int index1 = 0; index1 <= MaxValueOfXLimit; index1++)
            {
                for (int index2 = 0; index2 <= MaxValueOfYLimit; index2++)
                {
                    Console.WriteLine("Array [" + index1 + "][" + index2 + "] : " + array[index1, index2]);
                }
            }

        }
    }

    class MainLineLogic
    {
        static void Main()
        {
            Console.Write("Enter x value of array: ");
            int xRef = int.Parse(Console.ReadLine());
            Console.Write("Enter y value of array: ");
            int yRef = int.Parse(Console.ReadLine());
            ObjectInputData TheObjectCreated = new ObjectInputData(xRef,yRef);

            //how do you reference/output a specified value in the array created in the object TheObjectCreated from Main()?
            //I am wanting to add the feature of typing in index number to search for data in array. For instance, x value of 2
            //& index number y value of 3 (assuming not out of bounds defined by user) yields the contents of array[2,3] from TheObjectCreated
            //In other words, be able to output the data in any given "cell" defined by x and y in any object created under class ObjectInputData "blueprint".
        }

    }
}