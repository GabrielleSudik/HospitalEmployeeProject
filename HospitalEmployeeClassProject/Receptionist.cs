using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployeeClassProject
{
    class Receptionist : Employee
    {
        //fields

        private string department;
        private bool onPhone;


        //properties

        public string Department { get; set; }

        public string OnPhone { get; set; }


        //constructors

        public Receptionist()
        {

        }


        //methods


        public virtual void PrintInfo(string name, int employeeNumber)
        {
            Console.WriteLine($"{name}'s employee number is {employeeNumber}");
        }



    }
}
