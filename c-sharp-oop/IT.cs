using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_oop
{
    internal class IT : Employee
    {
        private int exp;
        
        public IT (string name, int salary, int exp) : base(name, salary)
        {
            this.exp = exp;
        }
        public override void showEmployee()
        {
            Console.WriteLine("Name = " + base.Name);
            Console.WriteLine("Salary = " + base.Salary);
            Console.WriteLine("Exp = " + this.exp);
            Console.WriteLine("------------------------");
        }
    }
}
