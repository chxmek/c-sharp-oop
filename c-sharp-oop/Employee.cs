﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_oop
{
    internal abstract class Employee
    {
        // field
        private string name;
        private int salary;
        protected string officeName = "chxmek Studio";      // field นี้สามารถเข้าถึงได้จากคลาสลูก (this.officeName)

        // default constructor(ชื่อจะเหมือนกับ class), !!เมื่อ class ลูกไม่มี constructor ต้องมีการสร้าง default constructor ที่ class แม่
        //public Employee()
        //{
        //    Console.WriteLine("Create Employee Object");
        //}

        // parameter constructor, เมื่อไม่มีการส่งค่ามาที่ parameter constructor จะไปเรียกใช้ default constructor แทน
        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
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

        //// สร้าง property
        //public string Name
        //{
        //    get { return name; }    // getter => อ่านข้อมูล
        //    set { name = value; }   // setter => เขียนข้อมูล, value คือค่าที่อยากจะกำหนดให้ field name
        //}
        //public int Salary
        //{
        //    get { return salary; }
        //    set { salary = value; }
        //}

        //// แบบลดรูป property (ใช้!!)
        //public string Name { get; set; }
        //public int Salary { get; set; }

        // ใช้ Visual Studio 2022 Generate ให้ โดยทำการ select ที่ field แล้วกด edit ที่ tools bar >> Refactor >> Encapsulate Field
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }

        // สร้าง method
        // ใส่ virtual ใน method คลาสแม่ และ ใส่ override ใน method คลาสลูก เพื่อให้คลาสลูกสามารถปรับแต่ง method ได้ โดยชื่อ method ต้องเหมือนกัน
        public virtual void showEmployee()
        {
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Salary = " + this.Salary);
            Console.WriteLine("------------------------");
        }

        // สร้าง Abstract method ที่คลาสแม่แล้วระบุแค่ชื่อ method และไม่มีการทำงานข้างใน(จะระบุการทำงานแค่ในคลาสลูก) มีข้อบังคับ คือ ลูกจะต้องนำไปให้ทุกๆคลาส
        // เมื่อมีการระบุ abstract method จะต้องระบุ abstract ที่ชื่อคลาสด้วย(abstract class Employee)
        public abstract double reportIncome();
    }
}