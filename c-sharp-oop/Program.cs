//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using c_sharp_oop;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)                        // class ที่มี function Main ทำงานด้าานในจะเป็น class ที่ถูกเรียกใช้งานตัวแรกเสมอ
        {
            Employee emp1 = new Employee("Mek", 60000);
            Employee emp2 = new Employee("Jojo", 20000);
            Employee emp3 = new Employee("Pong", 80000);

            //emp1.showDetail();

            //emp1.setName("Chawanwit");                       // เรียกใช้ setter method เพื่อเปลี่ยนค่า private field 
            //emp1.setSalary(100000);
            //Console.WriteLine(emp1.getName());               // เรียกใช้ getter method เพื่ออ่านค่า private field
            //Console.WriteLine(emp1.getSalary());

            emp1.Name = "Chawanwit";                           // เรียกใช้ property setter
            Console.WriteLine(emp1.Name);                      // เรียกใช้ property getter
            emp1.Salary = 100000;
            Console.WriteLine(emp1.Salary);

            Console.ReadKey();                                 // ปิดการแสดงข้อความเสริมใน console
        }
    }
}