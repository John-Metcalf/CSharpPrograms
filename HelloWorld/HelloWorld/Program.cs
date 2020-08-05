using System;

namespace HelloWorld
{

    class Staff
    {

        private string nameOfStaff;
        private const int hourlyRate = 45;
        private int hWorked;

        public int HoursWorked
        {
 
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }

            get
            {
                return hWorked;
            }
        }


        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }


        public int CalculatePay()
        {
            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }


        public int CalculatePay(int bonus, int allowance)
        {
            if (hWorked > 0)
                {
                Console.WriteLine("received a bonus in the amount of {0:C} and an allowance of {1:C}.", bonus, allowance);
                return hWorked * hourlyRate + bonus + allowance;
                }
            else
                return 0;
        }


        public override string ToString()
        {
            Console.WriteLine(nameOfStaff + " worked for " + hWorked + " hours at an hourly rate of " + hourlyRate + " dollars per hour.");
            return (nameOfStaff + hWorked + hourlyRate);
        }


        public Staff(string name)
        {
            nameOfStaff = name;
            Console.Write(name + " ");
        }

        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.Write(nameOfStaff + " ");
        }
        
    }



    class Program
    {
        static void Main(string[] args)
        {
            int pay;

            Console.WriteLine();
   
            Staff staff1 = new Staff("Carol");
            staff1.HoursWorked = 127;
            pay = staff1.CalculatePay(100, 200);
            staff1.ToString();
            staff1.PrintMessage();
            Console.WriteLine("Pay = {0:C}", pay);
            Console.WriteLine();

            Staff staff2 = new Staff("David", "Channing");
            staff2.HoursWorked = 160;
            pay = staff2.CalculatePay(100, 200);
            staff2.ToString();
            staff2.PrintMessage();
            Console.WriteLine("Pay = {0:C}", pay);
            Console.WriteLine();

            Staff staff3 = new Staff("Jill", "Aswegago");
            staff3.HoursWorked = 127;
            pay = staff3.CalculatePay(100,200);
            staff3.ToString();
            staff3.PrintMessage();
            Console.WriteLine("Pay = {0:C}", pay);
            Console.WriteLine();
        }
    }
}