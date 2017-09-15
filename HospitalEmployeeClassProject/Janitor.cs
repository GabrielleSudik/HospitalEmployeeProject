using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployeeClassProject
{
    class Janitor : Employee
    {
        //fields

        private string department;
        private bool isSweeping;


        //properties

        public string Department { get; set; }

        public string IsSweeping { get; set; }


        //constructors

        public Janitor()
        {

        }


        //methods



    }
}
