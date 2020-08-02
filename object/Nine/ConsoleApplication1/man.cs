using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Calculate //抽象类
    {
        public abstract double Perimeter(); //抽象的周长

        public abstract double Area(); //抽象的面积
    }

    /// <summary>
    /// 求圆的面积跟周长
    /// </summary>
    class Circle : Calculate
    {
        public Circle(double RSize)
        {
            this.R = RSize;
        }

        double _r;
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }
        public override double Area()
        {
            return Math.PI * this.R * this.R;
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * this.R;
        }
    }

    /// <summary>
    /// 求矩形的面积跟周长
    /// </summary>
    class Rectangle : Calculate
    {
        public Rectangle(double Wide, double Long)
        {
            this.Long = Long;
            this.Wide = Wide;
        }

        double _long;
        public double Long
        {
            get { return _long; }
            set { _long = value; }
        }

        double _wide;
        public double Wide
        {
            get { return _wide; }
            set { _wide = value; }
        }
        public override double Area()
        {
            return this.Long * this.Wide;
        }

        public override double Perimeter()
        {
            return 2 * (this.Wide + this.Long);
        }
    }
}
