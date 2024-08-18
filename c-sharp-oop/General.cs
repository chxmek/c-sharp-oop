using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_oop
{
    internal interface General      // สร้าง interface เพื่อให้ class อื่นสืบทอดไปใช้ได้ โดย method ใน interface จะเป้น abstract method
    {
        void showUniform();
        string showBonus();
    }
}
