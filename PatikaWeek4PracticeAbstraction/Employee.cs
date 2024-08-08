using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PracticeAbstraction
{
    public abstract class BaseWorker // Creating an abstract  base class
    {
        public string Name {  get; set; } // Defining properties

        public string Surname { get; set; }

        public string Department    { get; set; }

        public string Position { get; set; }

        public abstract void Gorev(); // Creating an abstract method
        
    }

    public class Worker : BaseWorker // Creating a new class
    {
        public Worker() { } // Default constructor

        public Worker(string name, string surname, string department, string position) // Consructor with parameters
        {
            Name = name;
            Surname = surname;
            Department = department;
            Position = position;
        }

        public override void Gorev() // Overriding the first method 
        {
            Console.WriteLine($"Ben {Name} {Surname}, bu şirketin {Department} departmanında {Position} olarak çalışıyorum.");
        }

    }
}
