using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _sex;
        public int Sex
        {
            get { return _sex; }
            set { _sex = value;}
        }

        public void Func()
        {
            Console.WriteLine("{0} is {1} speak", this._name, this._sex);
        }
    }

    class Dog:Animal
    {
        public Dog(string name, int sex)
        {
            this.Name = name;
            this.Sex = sex;
        }

        public void DogFunc()
        {
            Console.WriteLine("Dog eat shit", this.Name);
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int sex)
        {
            this.Name = name;
            this.Sex = sex;
        }

        public void CatFunc()
        {
            Console.WriteLine("{0} Cat mouse", this.Name);
        }
    }
}

