//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using c_sharp_oop;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)             // class ที่มี function Main ทำงานด้าานในจะเป็น class ที่ถูกเรียกใช้งานตัวแรกเสมอ
        {
            Employee emp1 = new Employee();         // object
            Console.WriteLine(emp1.name);
            Console.WriteLine(emp1.salary);
            Console.ReadKey();                      // ปิดการแสดงข้อความเสริมใน console
        }
    }
}