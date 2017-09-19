using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployeeClassProject
{
    class Employee
    {
        //fields

        protected string name;
        protected int employeeNumber;
        protected double hourlyWage;
        protected double hoursThisWeek;


        //properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
            set { this.employeeNumber = value; }
        }

        public double HourlyWage
        {
            get { return this.hourlyWage; }
            set { this.hourlyWage = value; }
        }


        //constructors


            public Employee()
        {

        }

        public Employee(string name)
        {
            this.name = name;
        }


        //methods

            public virtual void PrintInfo(string name, int employeeNumber)
        {
            Console.WriteLine($"{name}'s employee number is {employeeNumber}");
        }

        public virtual double WeeklyPay(double hourlyWage, double hoursThisWeek)  //default for hourly wage earners
        {
            double paycheck = hourlyWage * hoursThisWeek;
            return paycheck;
        }

    }
}
