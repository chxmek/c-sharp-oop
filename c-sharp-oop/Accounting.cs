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
        // สร้าง field
        private string gender;

        // สร้าง constructor
        public Accounting(string name, int salary, string gender) : base(name, salary)   // ใช้ base เพื่ออ้างอิงถึง private constructor ที่อยู่ในคลาสแม่
        {
            this.gender = gender;
            Console.WriteLine(name + " working at " + officeName);
        }
    }
}
