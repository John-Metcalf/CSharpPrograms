using System;

namespace Exp2
{

    class ObjectInputData
    {
        private int[,] _array;

        public ObjectInputData(int xValue, int yValue)
        {
            //creates the size of array in object based on user input
            _array = new int[xValue, yValue];
            int MaxValueOfXLimit = xValue - 1, MaxValueOfYLimit = yValue - 1;


            //this for loop reads the data from user into array
            for (int index1 = 0; index1 <= MaxValueOfXLimit; index1++)
            {
                for (int index2 = 0; index2 <= MaxValueOfYLimit; index2++)
                {
                    Console.WriteLine("Enter Data for array [" + index1 + "][" + index2 + "]: ");
                    this._array[index1, index2] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //this for loop prints out the input data of array in sequential order
            for (int index1 = 0; index1 <= MaxValueOfXLimit; index1++)
            {
                for (int index2 = 0; index2 <= MaxValueOfYLimit; index2++)
                {
                    Console.WriteLine("Array [" + index1 + "][" + index2 + "] : " + _array[index1, index2]);
                }
            }

        }

        public int[,] InternalArray
        {
            get
            {
                return _array;
            }
        }
    }

    class MainLineLogic
    {
        static void Main()
        {
            Console.Write("Enter x size of the 2 arrays to be created: ");
            int xRef = int.Parse(Console.ReadLine());
            Console.Write("Enter y size of 2 arrays to be created: ");
            int yRef = int.Parse(Console.ReadLine());
            ObjectInputData TheObjectCreated = new ObjectInputData(xRef, yRef);

            ObjectInputData The2ndObjectCreated = new ObjectInputData(xRef, yRef);

            Console.WriteLine("Enter X index value to search in both arrays: ");
            int xCheck = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Y index value to search in both arrays: ");
            int yCheck = Convert.ToInt32(Console.ReadLine());


            if(xCheck > -1 && xCheck < xRef & yCheck > -1 && yCheck < yRef)
            {
                Console.WriteLine($"Data in array 1 at location [{xCheck}, {yCheck}] is :{TheObjectCreated.InternalArray[xCheck, yCheck]}");
                Console.WriteLine($"Data in array 2 at location [{xCheck}, {yCheck}] is :{The2ndObjectCreated.InternalArray[xCheck, yCheck]}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

    }
}
