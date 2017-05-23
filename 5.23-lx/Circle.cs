using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._23_lx
{
    /// <summary>
    /// 派生类：圆形
    /// </summary>
    class Circle : Shape
    {
        /// <summary>
        /// 半径
        /// </summary>
        protected double Radius;
        public Circle() {

        }
        /// <summary>
        /// 圆形的构造函数，初始化颜色值
        /// </summary>
        /// <param name="Color">颜色</param>
        public Circle(string Color,double Radius)
        {
            this.Color = Color;
            this.Radius = Radius;
        }
        /// <summary>
        /// 圆的面积
        /// </summary>
        /// <returns></returns>
        public double GetArea() {
            return Math.Pow(Radius, 2) * Math.PI;
        }
        /// <summary>
        /// 圆的周长
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter() {
            return Math.PI * Radius * 2;
        }
    }
}
