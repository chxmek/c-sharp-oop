using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_oop
{
    internal class Company
    {
        public static string name = "chxmek CompanyLimited";
        public static string founder = "Mr.Mek";

        // สร้าง List<กลุ่มข้อมูลที่ต้องการเก็บ หรือ กลุ่มของ object> list_Name = new List<...>
        public static List<Employee> employees = new List<Employee>();     // กลุ่มข้อมูล Employee จะถูกเก็บไว้ใน employees ผ่าน method addEmployee

        // ต้องเป็น static เหมือนกันถึงจะทำงานด้วยกันได้
        public static void addEmployee(Employee person)
        {
            employees.Add(person);
        }
        public static void getEmployees()
        {
            foreach (Employee person in employees) 
            {
                person.showEmployee();
            }
        }
    }
}
