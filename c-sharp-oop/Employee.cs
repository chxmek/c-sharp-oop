﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_oop
{
    internal class Employee
    {
        // field
        private string name;
        private int salary;

        //// default constructor(ชื่อจะเหมือนกับ class)
        //public Employee()
        //{
        //    Console.WriteLine("Create Empty Object");
        //}

        // parameter constructor
        public Employee(string nameValue, int salaryValue)
        {
            this.name = nameValue;
            this.salary = salaryValue;
        }

        //// method
        //public void showDetail()
        //{
        //    Console.WriteLine("Name: " + this.name);
        //    Console.WriteLine("Salary: " + this.salary);
        //}

        //// ใช้ getter, setter เพื่อเข้าถึง private
        //// setter => เขียนข้อมูล
        //public void setName(string newName)
        //{
        //    this.name = newName;
        //}
        //public void setSalary(int newSalary)
        //{
        //    this.salary = newSalary;
        //}
        //// getter => อ่านข้อมูล
        //public string getName()
        //{
        //    return this.name;
        //}
        //public int getSalary() 
        //{
        //    return this.salary;
        //}

        // สร้าง property
        public string Name
        {
            get { return name; }    // getter => อ่านข้อมูล
            set { name = value; }   // setter => เขียนข้อมูล, value คือค่าที่อยากจะกำหนดให้ field name
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}