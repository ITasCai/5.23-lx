using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this关键字
{
    class Student
    {
        private string number;
        private double score;
        private string name;


        public Student(string number,double score,string name) {
            this.number = number;
            this.score = score;
            this.name = name;
        }
        /// <summary>
        /// 学号
        /// </summary>
        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        /// <summary>
        /// 成绩
        /// </summary>
        public double Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public double Show() {
            Console.WriteLine("学号{0},成绩:{1},姓名{2}",number,score,name);
            double result = ChangeScore.Caculate(this);
            return result;
        }
    }
}
