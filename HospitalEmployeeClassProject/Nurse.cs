using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployeeClassProject
{
    class Nurse : Employee
    {
        //fields

        private string specialty;
        private double annualSalary;
        private int numberOfPatients;

        //properties

        public string Specialty { get; set; }

        public double AnnualSalary { get; set; }

        public int NumberOfPatients { get; set; }


        //constructors

        public Nurse(string name)
        {
            this.name = name;
        }
        //methods

        public override double WeeklyPay(double annualSalary, double hoursThisWeek)

        {
            double paycheck = annualSalary / 52;
            return paycheck;
        }


        public virtual void PrintInfo(string name, int employeeNumber, int numberOfPatients)
        {
            Console.WriteLine($"{name}'s employee number is {employeeNumber}");
            Console.WriteLine($"This nurse currently has {numberOfPatients} patients.");
        }



    }
}
