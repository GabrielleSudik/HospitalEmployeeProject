using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployeeClassProject
{
    class Doctor : Employee
    {
        //fields

        private string specialty;
        private double annualSalary = 250000;

        //properties

        public string Specialty { get; set; }

        public double AnnualSalary { get; set; }


        //constructors

        public Doctor(string name)
        {
            this.name = name;
            this.annualSalary = annualSalary;
        }


        //methods

        public override double WeeklyPay(double annualsalary, double hourWorked)  //overrides hourly wage earner method

        {
            double paycheck = annualsalary / 52;
            return paycheck;
        }

        //public void Expertise(string specialty)
        //{
        //    Console.WriteLine($"This doctor's area of expertise is {specialty}.");
        //}


        public virtual void PrintInfo(string name, int employeeNumber, string specialty)
        {
            Console.WriteLine($"{name}'s employee number is {employeeNumber}.");
            Console.WriteLine($"The doctor's specialty is {specialty}.");
        }



    }
}

