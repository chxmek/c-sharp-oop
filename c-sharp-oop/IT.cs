﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_oop
{
    internal class IT : Employee, General
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
        public override double reportIncome()
        {
            return (base.Salary * 12) * this.exp;
        }

        public void showUniform()
        {
            Console.WriteLine("Uniform: Black Color");
        }

        public string showBonus()
        {
            return "Bonus 59%";
        }
    }
}
