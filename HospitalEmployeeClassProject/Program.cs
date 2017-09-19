using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalEmployeeClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hospital Employee Tracking System.");
            Console.WriteLine();

            //you are doing a bit of experimenting here
            //with different things in constructors, etc.
            //you still have no idea what the difference between fields and properties is
            //or get/set

            //DOH! A much better way might have been to assign all parameters in each derived constructor
            //instead of putting the parameters in the methods

            Doctor renee = new Doctor("Renee");

            renee.PrintInfo("Renee", 01, "heart");

            Console.WriteLine("This week's pay was:");
            Console.WriteLine(  renee.WeeklyPay(520000, 40));

            Console.WriteLine();

            Surgeon lauren = new Surgeon();

            lauren.PrintInfo("Lauren", 02, "brain", false);

            Console.WriteLine(lauren.Name);

            Console.WriteLine();

            Nurse lori = new Nurse("Lori");

            lori.PrintInfo("Lori", 03, 15);

            Console.WriteLine(  $"This week the paycheck was for ${lori.WeeklyPay(52000, 52)}.");

            Console.WriteLine(lori.Name); //this prints the name because my constructor accepts a name

            Console.WriteLine();


            Nurse kim = new Nurse("Kim");

            kim.PrintInfo("Kim", 05, 15);

            Console.WriteLine($"This week the paycheck was for ${kim.WeeklyPay(64000, 52)}.");


            Console.WriteLine();

            Janitor lisa = new Janitor();

            lisa.PrintInfo("Lisa", 04, false);

            Console.WriteLine($"This week the paycheck was for ${lisa.WeeklyPay(8.10, 40)}.");

            Console.WriteLine();

            Administrator chrissy = new Administrator();

            chrissy.PrintInfo("Chrissy", 06, "Pediatrics");

            //Console.WriteLine($"This week the paycheck was for ${chrissy.WeeklyPay(34.50, 40)}.");
            //why doesn't that work? it works for Janitor . ??

            Console.WriteLine();

            Administrator tanya = new Administrator();

            chrissy.PrintInfo("Tanya", 07, "Neurology");

            Console.WriteLine();

            Console.ReadLine();


        }
    }
}
