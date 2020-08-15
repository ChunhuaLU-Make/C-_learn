using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Supermarket
    {
		public Supermarket()
		{
			_lib.GetGoods("Lenove", 100);
			_lib.GetGoods("Vegtable", 50);
			_lib.GetGoods("Car", 10);
			_lib.GetGoods("Ice", 1000);
		}

		Repository _lib = new Repository();

		public void AskBuy()
		{
			Console.WriteLine("Welcome to supermarket, please you need why?");
			Console.WriteLine("We have Lenove computer and Vegtable, and Car and Ice");
			string Type = Console.ReadLine();
			Console.WriteLine("You want need how much");
			int Count = Convert.ToInt32(Console.ReadLine());

			//去仓库取货
			Commodity[] comms = _lib.OutputGoods(Type, Count);

			//要钱
			double Money = GetMoney(comms);
			Console.WriteLine("You give me Preferential befor{0}￥", Money);

			//提示客户有那些打折方式
			Console.WriteLine("Please select your Preferential way");
			Console.WriteLine("1. not; 2.99; 3.85; 4.Buy 300￥send 50￥");
			string Input = Console.ReadLine();
			Preferential OutMoney = SelectWay(Input);
			double TotalMoney = OutMoney.PreferentialWay(Money);
			Console.WriteLine("You give me {0} ￥", TotalMoney);
		}

		public double GetMoney(Commodity[] comms)
		{
			double TotalMoney = 0;
			for (int i = 0; i < comms.Length; i++)
			{
				TotalMoney += comms[i].Price;
			}

			return TotalMoney;
		}

		public Preferential SelectWay(string Input)
		{
			Preferential way = null;
			switch (Input)
			{
				case "1":
					return way = new NormalMoney();
				case "2":
					return way = new Preferential99(0.99);
				case "3":
					return way = new Preferential99(0.85);
			}
			return way;
		}

		public void ShowRepository()
		{
			_lib.ShowGoods();
		}

	}
}
