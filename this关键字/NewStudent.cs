using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this关键字
{
    class NewStudent:Student
    {
        private string school;

        public NewStudent(string number, double score, string name,string school) : base(number, score, name)
        {
            this.school = school;
        }

        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }
    }
}
