using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace EmpMat1
{

    public class InterviewManager
    {
        private readonly string positionName;

        private readonly List<Applicant> applicants;


        public InterviewManager(string positionName)
        {
            this.applicants = new List<Applicant>();
            this.positionName = positionName;
        }

        public List<Applicant> Applicants
        {
            get => applicants;
        }

        public int GenerateUniqueId()
        {
            var random = new Random();

            int newId;
            do
            {
                newId = random.Next(10000, 100000);
            } while (this.Applicants.Exists(applicant => applicant.Id == newId));

            return newId;
        }

        public Applicant AddApplicant(string firstName, string middleName, string lastName, int age, bool drugTest)
        {
            var newApplicant = new Applicant(this.GenerateUniqueId());
            newApplicant.FirstName = firstName;
            newApplicant.MiddleName = middleName;
            newApplicant.LastName = lastName;
            newApplicant.Age = age;
            newApplicant.DrugTest = drugTest;

            this.AddApplicant(newApplicant);
            return newApplicant;
        }

        public void AddApplicant(Applicant applicant)
        {
            Console.WriteLine($"Adding applicant: {applicant.FirstName} {applicant.MiddleName} {applicant.LastName} {applicant.Id} {applicant.DrugTest}");
            Console.WriteLine();
            this.Applicants.Add(applicant);
        }
    }
}
