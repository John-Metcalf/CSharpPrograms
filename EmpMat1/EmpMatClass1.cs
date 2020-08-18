using System;
namespace FirstDataBase
{
    internal class EmpMatClass1
    {
        public EmpMatClass1(int ArrayValue)
        {
            string[] ApplicantDataBase = new string[ArrayValue];

            for (int counter = 0; counter < ApplicantDataBase.Length; ++counter)
                {
                Console.WriteLine("Enter Name:");
                string NameOfApplicant = Console.ReadLine();
                ApplicantDataBase[counter] = NameOfApplicant;
                }

            Console.WriteLine();

            for (int counter = 0; counter < ApplicantDataBase.Length; ++counter)
            {
                Console.WriteLine(ApplicantDataBase[counter]);
            }
        }
    }
}