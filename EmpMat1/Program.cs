using System;
using FirstDataBase;

namespace EmEmpMatClass1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number Of Applicants:");
            int ValueOfArray = Convert.ToInt32(Console.ReadLine());
            EmpMatClass1 ThisIsTheName = new EmpMatClass1(ValueOfArray);
        }

    }
}
