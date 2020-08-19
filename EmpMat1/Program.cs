using System;
using System.Collections.Generic;

namespace EmpMat1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var manager = new InterviewManager("Janitor");

            int Counter1 = 1;

            Console.WriteLine("Enter Number of Applicants");

            int applicantCount;
            while (!(int.TryParse(Console.ReadLine(), out applicantCount) && applicantCount > 0))
            {
                Console.WriteLine("You entered an invalid number. Try again.");
            }

            //int NumberOfApplicants = Convert.ToInt32(Console.ReadLine());


            for (int counter = 0; counter < applicantCount; counter++)
            {
                var a = new Applicant(manager.GenerateUniqueId());
                Console.WriteLine();
                Console.WriteLine($"Applicant # {Counter1}");
                Console.WriteLine();
                Console.WriteLine("Enter First Name:");
                a.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Middle Name:");
                a.MiddleName = Console.ReadLine();
                Console.WriteLine("Enter Last Name:");
                a.LastName = Console.ReadLine();

                bool willTakeTest;
                do
                {
                    Console.WriteLine("Will you take a drug test? (\"true\" or \"false\").");

                } while (!bool.TryParse(Console.ReadLine(), out willTakeTest));

                a.DrugTest = willTakeTest;
                

                Console.WriteLine("Enter Age");
                a.Age = Convert.ToInt32(Console.ReadLine());
                manager.AddApplicant(a);
                Counter1 = Counter1 + 1;
            }

            Console.WriteLine("__________________________________________________________________________________________________________________");

            foreach (var applicant in manager.Applicants)
            {
                Console.WriteLine();
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
                if (applicant.DrugTest && applicant.Age > 17)
                {
                    Console.WriteLine("You may apply after drug test.");
                }
                else
                {
                    Console.WriteLine("You cannot work here unless you take a drug test and your age is 18 or over.");
                }
                Console.WriteLine();
            }
            
        }
    }
}