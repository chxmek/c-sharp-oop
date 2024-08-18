using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_oop
{
    internal class Sale : Employee, General
    {
        private string area;
        private double commission = 10000;
        
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

        public override double reportIncome()
        {
            return (base.Salary * 12) + (this.commission * 12);
        }

        public void showUniform()
        {
            Console.WriteLine("Uniform: Pink Color");
        }

        public string showBonus()
        {
            return "Bonus: 50%";
        }
    }
}
