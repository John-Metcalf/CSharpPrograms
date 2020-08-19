using System;

namespace EmpMat1
{
    public class Applicant
    {
        // static members are shared across all instances
        //private static int idCounter = 0;

        public Applicant(int id)
        {
            //var random = new Random();
            //var next = random.Next(1, 100);
            this.Id = id;
        }

        public int Id { get; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool DrugTest { get; set; }
    }
}