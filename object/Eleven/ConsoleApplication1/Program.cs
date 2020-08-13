using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize();
            bf.Deserialize();


            MakeComputer Computer = new MakeComputer();
            NoteBook YourCom = Computer.YourComputer();
            YourCom.PlayComputer();
        }
    }
}
