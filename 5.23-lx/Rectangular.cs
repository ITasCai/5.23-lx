using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._23_lx
{
    /// <summary>
    /// 派生类：矩形
    /// </summary>
    class Rectangular:Shape
    {
        /// <summary>
        /// 长
        /// </summary>
        protected double Length;
        /// <summary>
        /// 宽
        /// </summary>
        protected double Width;

        public Rectangular() {

        }

        public Rectangular(string Color,double Length,double Width)
        {
            this.Color = Color;
            this.Length = Length;
            this.Width = Width;
        }
        /// <summary>
        /// 面积
        /// </summary>
        /// <returns></returns>
        public double GetArea() {
            return Length * Width;
        }
        /// <summary>
        /// 周长
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter() {
            return (Length + Width) * 2;
        }
    }
}
