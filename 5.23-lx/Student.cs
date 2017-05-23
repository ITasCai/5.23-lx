using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._23_lx
{
    class Student:Person
    {
        public new void Writelnfo() {
            Console.WriteLine("我是人类的学生");
        }
        public override void Task()
        {
            Console.WriteLine("我要学习");
        }
    }
}
