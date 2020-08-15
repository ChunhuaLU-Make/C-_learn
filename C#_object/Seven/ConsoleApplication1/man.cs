using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        public Person(string Na)
        {
            this._name = Na;
        }
        protected  string _name;
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public void Func()
        {
            Console.WriteLine("I'm person, name is {0}", this.Name);
        }
    }
    class Woman : Person
    {
        public Woman(string Name, int Id) : base(Name)
        {
            _id = Id;
        }
        int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public void FuncId()
        {
            Console.WriteLine("My id is {0}, name {1}", this.Id, _name);
        }
    }

    class Boy:Person
    {
        public Boy(string name) : base(name)
        {
        }
    }
}
