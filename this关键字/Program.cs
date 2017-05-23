using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("1001",88,"狗蛋");
            double result = student.Show();
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
