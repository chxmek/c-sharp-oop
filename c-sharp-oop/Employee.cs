using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_oop
{
    internal class Employee
    {
        // field
        private string name = "Mek";
        private int salary = 50000;

        // default constructor(ชื่อจะเหมือนกับ class)
        public Employee()
        {
            Console.WriteLine("Create Empty Object");
        }

        // parameter constructor
        public Employee(string nameValue, int salaryValue)
        {
            Console.WriteLine("name: " + nameValue);
            Console.WriteLine("salary: " + salaryValue);
        }

    }
}
