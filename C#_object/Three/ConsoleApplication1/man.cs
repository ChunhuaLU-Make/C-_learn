using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Ticket
    {
        //初始化价格，公里数
        public Ticket(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }
            this._distance = distance;
        }

        private double _distance;
        public double Distance
        {
            get { return _distance; }
        }

        private double _price;
        public double Price
        {
            get {
                if (this.Distance > 0 && this.Distance <= 100)
                {
                    _price = 1;
                }
                else if (this.Distance > 101 && this.Distance < 200)
                {
                    _price = 0.95;
                }
          
                return _price; }  //价格只读属性
        }

        public void calculation_road()
        {
            Console.WriteLine("{0}", this.Distance * this.Price);
        }
    }
}
