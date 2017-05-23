using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._23_lx
{
    class Squarecs:Rectangular
    {
        /// <summary>
        /// 正方形的构造函数
        /// </summary>
        /// <param name="Color">颜色</param>
        public Squarecs(string Color) {
            this.Color = Color;
        }
        /// <summary>
        /// 正方形面积
        /// </summary>
        /// <returns></returns>
        public new double GetArea()
        {
            //new可以隐藏父类的方法，重新设置
            return Length * Width;
        }
        /// <summary>
        /// 正方形周长
        /// </summary>
        /// <returns></returns>
        public new double GetPerimeter()
        {
            return Length * 4;
        }
       
    }
}
