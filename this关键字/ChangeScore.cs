using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this关键字
{
    static class ChangeScore
    {
        public static double Caculate(Student student) {
            double result = 0.075 * student.Score;
            return result;


        }
    }
}
