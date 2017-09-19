using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployeeClassProject
{
    class Administrator
    {
        //fields

        private string department;


        //properties

        public string Department { get; set; }


        //constructors

        public Administrator()
        {

        }


        //methods


        public virtual void PrintInfo(string name, int employeeNumber, string department)
        {
            Console.WriteLine($"{name}'s employee number is {employeeNumber}");
            Console.WriteLine($"{name}'s department is {department}.");
        }




    }
}
