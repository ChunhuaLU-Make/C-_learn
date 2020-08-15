using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Commodity
    {
        public Commodity(double price, string id, int count, string note)
        {
            this.Price = price;
            this.Id = id;
            this.Count = count;
            this.Note = note;
        }

        double _price;
        public double Price { get => _price; set => _price = value; }

        string _id;
        public string Id { get => _id; set => _id = value; }

        int _count;
        public int Count { get => _count; set => _count = value; }

        string _note;
        public string Note { get => _note; set => _note = value; }
    }

    class Lenove : Commodity
    {
        public Lenove(double price, string id, int count, string note) : base(price, id, count, note) { }
    }

    class Vegtable : Commodity
    {
        public Vegtable(double price, string id, int count, string note) : base(price, id, count, note) { }
    }

    class Car : Commodity
    {
        public Car(double price, string id, int count, string note) : base(price, id, count, note) { }
    }

    class Ice : Commodity
    {
        public Ice(double price, string id, int count, string note) : base(price, id, count, note) { }
    }
}
