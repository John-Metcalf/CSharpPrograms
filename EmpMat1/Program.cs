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
                do
                {
                    Console.WriteLine("Will you take a drug test? 1 for yes 0 for no.");
                    a.DrugTest = Console.ReadLine();

                } while (a.DrugTest != "1" && a.DrugTest != "0");
                Console.WriteLine("Enter Age");
                a.Age = Convert.ToInt32(Console.ReadLine());
                applicantList.Add(a);
            }

            Console.WriteLine("__________________________________________________________________________________________________________________");

            foreach (var applicant in applicantList)
            {
                Console.WriteLine($"{applicant.FirstName} {applicant.MiddleName} {applicant.LastName}, Age: {applicant.Age}, ID: {applicant.Id}");
                if (applicant.Age < 18)
                {
                    Console.WriteLine("You are too young to work here.");
                }
                else
                {
                    Console.WriteLine("You are old enough to work here.");
                }
                Console.WriteLine();
                if (applicant.DrugTest == "1")
                {
                    Console.WriteLine("You may apply after drug test.");
                }
                else
                {
                    Console.WriteLine("You cannot work here unless you take a drug test.");
                }

            }
            
        }
    }
}