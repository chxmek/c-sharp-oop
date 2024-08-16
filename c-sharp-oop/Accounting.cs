using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_oop
{
    // Inheritance(การสืบทอดคุณสมบัติ) >> Class Accounting สืบทอดมาจาก Class Employee(คลาสแม่)
    internal class Accounting : Employee
    {
        // สร้าง constructor
        public Accounting() 
        {
            Console.WriteLine("Create Accounting Object");
        }
    }
}
