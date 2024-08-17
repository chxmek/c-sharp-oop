using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_oop
{
    internal class Sale : Employee
    {
        private string area;
        
        public Sale (string name, int salary, string area) : base(name, salary)
        {
            this.area = area;
        }
        public override void showEmployee()
        {
            Console.WriteLine("Name = " + base.Name);
            Console.WriteLine("Salary = " + base.Salary);
            Console.WriteLine("Area = " + this.area);
            Console.WriteLine("------------------------");
        }
    }
}
