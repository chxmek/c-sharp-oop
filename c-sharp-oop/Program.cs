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
            //Employee emp1 = new Employee("Mek", 60000);
            //Employee emp2 = new Employee("Jojo", 20000);
            //Employee emp3 = new Employee("Pong", 80000);


            //emp1.showDetail();


            //emp1.setName("Chawanwit");                       // เรียกใช้ setter method เพื่อเปลี่ยนค่า private field 
            //emp1.setSalary(100000);
            //Console.WriteLine(emp1.getName());               // เรียกใช้ getter method เพื่ออ่านค่า private field
            //Console.WriteLine(emp1.getSalary());

            //emp1.Name = "Chawanwit";                           // เรียกใช้ property setter
            //Console.WriteLine(emp1.Name);                      // เรียกใช้ property getter
            //emp1.Salary = 100000;
            //Console.WriteLine(emp1.Salary);


            //Employee emp1 = new Accounting();                 // สร้าง(object)พนักงานแผนก Accounting
            //emp1.Name = "Jane";
            //emp1.Salary = 80000;
            //Console.WriteLine(emp1.Name);
            //Console.WriteLine(emp1.Salary);

            //Employee emp2 = new Sale();                       // สร้าง(object)พนักงานแผนก Sale
            //emp2.Name = "Sung";
            //emp2.Salary = 70000;
            //Console.WriteLine(emp2.Name);
            //Console.WriteLine(emp2.Salary);

            //Employee emp3 = new IT();                       // สร้าง(object)พนักงานแผนก IT
            //emp3.Name = "Kob";
            //emp3.Salary = 40000;
            //Console.WriteLine(emp3.Name);
            //Console.WriteLine(emp3.Salary);


            Accounting emp1 = new Accounting("Jane", 50000, "female");
            Sale emp2 = new Sale("Sung", 100000, "Bangkok");
            IT emp3 = new IT("Kob", 50000, 5);

            //emp1.showEmployee();
            //emp2.showEmployee();
            //emp3.showEmployee();

            //Console.WriteLine("Accounting = " + emp1.reportIncome());
            //Console.WriteLine("Sale = " + emp2.reportIncome());
            //Console.WriteLine("IT = " + emp3.reportIncome());


            // ใช้ static field (ที่อยู่ใน Class Company)
            //Console.WriteLine("Company's Name = " + Company.name);
            //Console.WriteLine("Founder = " + Company.founder);

            Company.addEmployee(emp1);
            Company.addEmployee(emp2);
            Company.addEmployee(emp3);

            Company.getEmployees();

            emp1.showUniform();
            emp1.showBonus();

            Console.ReadKey();                                 // ปิดการแสดงข้อความเสริมใน console
        }
    }
}