using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MakeComputer
    {
        public MakeComputer()
        {
            Console.WriteLine("Please input you want computer");
            this._computer = Console.ReadLine();
        }

        string _computer;
        public string Computer
        {
            get { return _computer; }
            set { _computer = value; }
        }

        public NoteBook YourComputer()
        {
            NoteBook ComputerName = null;

            switch (this.Computer)
            {
                case "lenovo":
                    ComputerName = new Levnote();
                    break;

                case "Ibm":
                    ComputerName = new Ibm();
                    break;

                case "Dell":
                    ComputerName = new Dell();
                    break;

                default:
                    break;
            }

            return ComputerName;
        }
    }

    abstract class NoteBook
    {
        public abstract void PlayComputer();

    }

    class Levnote : NoteBook
    {
        public override void PlayComputer()
        {
            Console.WriteLine("Welcom to levnote computer");
        }
    }

    class Ibm : NoteBook
    {
        public override void PlayComputer()
        {
            Console.WriteLine("Welcom to Ibm computer");
        }
    }

    class Dell : NoteBook
    {
        public override void PlayComputer()
        {
            Console.WriteLine("Welcom to Dell computer");
        }
    }
}

