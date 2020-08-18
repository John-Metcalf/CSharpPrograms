using System;

namespace EmpMat1
{
    public class Applicant
    {
       
        public Applicant()
        {

            this.Id = 100;

        }

        public int Id { get;}
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }       
    }
}