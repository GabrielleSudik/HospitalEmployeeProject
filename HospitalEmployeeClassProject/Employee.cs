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

        public virtual double WeeklySalary(double hourlyWage, double hoursThisWeek)
        {
            double paycheck = hourlyWage * hoursThisWeek;
            return paycheck;
        }


        //methods


    }
}
