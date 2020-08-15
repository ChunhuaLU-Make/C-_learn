using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Repository
    {
		public Repository()
		{
			_list.Add(new List<Commodity>());
			_list.Add(new List<Commodity>());
			_list.Add(new List<Commodity>());
			_list.Add(new List<Commodity>());
		}

		List<List<Commodity>> _list = new List<List<Commodity>>();

		public void GetGoods(string Type, int Count)
		{
			for (int i = 0; i < Count; i++)
			{
				switch (Type)
				{
					case "Lenove":
						_list[0].Add(new Lenove(100, Guid.NewGuid().ToString(), 1000, "Lenove computer note"));
							break;

					case "Vegtable":
						_list[1].Add(new Vegtable(30, Guid.NewGuid().ToString(), 1000, "This is Vegtable"));
							break;

					case "Car":
						_list[2].Add(new Car(13, Guid.NewGuid().ToString(), 1000, "Play car"));
							break;

					case "Ice":
						_list[3].Add(new Ice(12, Guid.NewGuid().ToString(), 1000, "Code ice"));
							break;
					default:
						break;

				}
			}
		}

		public Commodity[] OutputGoods(string Type, int Count)
		{
			Commodity[] Comms = new Commodity[Count];
			for (int i = 0; i < Count; i++)
			{
				switch (Type)
				{
					case "Lenove":
						Comms[i] = _list[0][0];
						_list[0].RemoveAt(0);
						break;

					case "Vegtable":
						Comms[i] = _list[1][0];
						_list[0].RemoveAt(0);
						break;

					case "Car":
						Comms[i] = _list[2][0];
						_list[0].RemoveAt(0);
						break;

					case "Ice":
						Comms[i] = _list[3][0];
						_list[0].RemoveAt(0);
						break;

					default:
						break;

				}
			}

			return Comms;
		}

		public void ShowGoods()
		{
			foreach (var  item in _list)
			{
				Console.WriteLine("Repository have:" + item[0].Note);
			}
		}

	}
}
