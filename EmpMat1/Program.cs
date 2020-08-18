using System;
using System.Collections.Generic;

namespace EmpMat1
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            var applicantList = new List<Applicant>();


            Console.WriteLine("Enter Number of Applicants");
            int NumberOfApplicants = Convert.ToInt32(Console.ReadLine());


            for (int counter = 0; counter < NumberOfApplicants; counter++)
            {
                var a = new Applicant();

                Console.WriteLine("Enter First Name:");
                a.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Middle Name:");
                a.MiddleName = Console.ReadLine();
                Console.WriteLine("Enter Last Name:");
                a.LastName = Console.ReadLine();
                Console.WriteLine("Enter Age");
                a.Age = Convert.ToInt32(Console.ReadLine());
                applicantList.Add(a);
            }

            Console.WriteLine("__________________________________________________________________________________________________________________");

            foreach (var applicant in applicantList)
            {
                Console.WriteLine($"{applicant.FirstName} {applicant.MiddleName} {applicant.LastName}, Age: {applicant.Age}, ID: {applicant.Id}");
                Console.WriteLine();
            }
            
        }
    }
}
