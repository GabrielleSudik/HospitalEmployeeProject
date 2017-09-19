using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployeeClassProject
{
    class Surgeon : Employee
    {
        //fields

        private string specialty;
        private double annualSalary = 300000;
        private bool isOperating;

        //properties

        public string Specialty { get; set; }

        public double AnnualSalary { get; set; }

        public bool IsOperating { get; set; }


        //constructors

            public Surgeon()
        {
            this.name = "Dr. Tall";
            this.specialty = specialty;
            this.isOperating = isOperating;
        }


        //methods

        public override double WeeklyPay(double annualSalary, double hoursThisWeek)

        {
            double paycheck = annualSalary / 52;
            return paycheck;
        }


        public virtual void PrintInfo(string name, int employeeNumber, string specialty, bool isOperating)
        {

            string opStatus = "";

            if (isOperating == true)
            {
                opStatus = "is";
            }

            else
            {
                opStatus = "is not";
            }
            Console.WriteLine($"{name}'s employee number is {employeeNumber}");
            Console.WriteLine($"The doctor's specialty is {specialty} and she {opStatus} currently operating." );
        }



    }
}
