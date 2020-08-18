using System;

namespace EmpMat1
{
    public class Applicant
    {
       
        public Applicant()
        {
            var random = new Random();
            var next = random.Next(1, 100);
            this.Id = next;

        }

        public int Id { get;}
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }       
    }
}