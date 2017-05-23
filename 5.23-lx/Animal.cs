using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._23_lx
{
    class Animal
    {

       
        private int age;
    
        private string sex;
        
        private string color;

        /// <summary>
        /// 有参数的构造方法，用于初始化
        /// </summary>
        /// <param name="age">年龄</param>
        /// <param name="sex">性别</param>
        /// <param name="color">颜色</param>
        public Animal(int age,string sex,string color) {
            this.age = age;
            this.sex = sex;
            this.color = color;
        }
        /// <summary>
        ///年龄
        /// </summary>
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        /// <summary>
        ///  性别
        /// </summary>
        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }
        /// <summary>
        /// 颜色
        /// </summary>
        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
        /// <summary>
        /// 动物的叫声
        /// </summary>
        public void Voice() {
            Console.WriteLine("动物及叫");
        }

        /// <summary>
        /// 重写tostring方法，用于输出信息
        /// </summary>
        /// <returns>返回信息内容</returns>
        public override string ToString()
        {
            return "年龄:" + age + "\n性别" + sex + "\n颜色" + color; 
        }
        
    }
}
