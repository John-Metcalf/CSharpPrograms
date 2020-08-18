using System;
using System.Collections.Generic;

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

        public Applicant AddApplicant(string firstName, string middleName, string lastName, int age)
        {
            var newApplicant = new Applicant();
            newApplicant.FirstName = firstName;
            newApplicant.MiddleName = middleName;
            newApplicant.LastName = lastName;
            newApplicant.Age = age;

            this.AddApplicant(newApplicant);
            return newApplicant;
        }

        public void AddApplicant(Applicant applicant)
        {
            Console.WriteLine($"Adding applicant: {applicant.FirstName} {applicant.MiddleName} {applicant.LastName} {applicant.Id}");
            Console.WriteLine();
            this.applicants.Add(applicant);
        }
    }
}
