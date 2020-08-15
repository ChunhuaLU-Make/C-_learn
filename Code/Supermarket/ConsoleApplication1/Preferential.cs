using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract  class Preferential
    {
        public abstract double PreferentialWay(double Monely);
    }

    class NormalMoney:Preferential
    {
        public override double PreferentialWay(double Monely)
        {
            return Monely;
        }
    }

    class Preferential99 : Preferential
    {
        public Preferential99(double rate)
        {
            this.Rate = rate;
        }

        public double Rate
        {
            get;
            set;
        }

        public override double PreferentialWay(double Money)
        {
            return Money * this.Rate;
        }
    }
}
