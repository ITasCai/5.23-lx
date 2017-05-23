using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._23_lx
{
    /// <summary>
    /// 基类：颜色类
    /// </summary>
    class Shape
    {  /// <summary>
    /// 颜色
    /// </summary>
        protected string Color;

        public Shape() {
        }
        /// <summary>
        /// 形状的构造方法，初始化颜色值
        /// </summary>
        /// <param name="Color"></param>
        public Shape(string Color) {
            this.Color = Color;
        }
        /// <summary>
        /// 取颜色值
        /// </summary>
        /// <returns>返回颜色</returns>
        public string GetColor() {
            return Color;
        }
    }
}
