using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Employee : Person
    {
        public string Position { get; set; }
        public Employee(string name, string position) : base(name)
        {
            Position = position;
        }
        public override void Display()
        {
            Console.WriteLine("Працівник");
            Console.WriteLine($"Ім'я: {Name};");
            Console.WriteLine($"Посада: {Position}");
        }
    }
}
