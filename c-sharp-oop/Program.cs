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
            Employee emp1 = new Employee();         // object, Employee() >> คือการเรียกใช้ constructor
            Employee emp2 = new Employee();
            Console.ReadKey();                      // ปิดการแสดงข้อความเสริมใน console
        }
    }
}