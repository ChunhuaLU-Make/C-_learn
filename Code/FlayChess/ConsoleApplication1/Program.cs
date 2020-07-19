using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static int[] g_Maps = new int[100];
        static int UserOne = 0;
        static int UserTwo = 0;
        static string UserName1 = null;
        static string UserName2 = null;

        static bool[] PlayTimes = new bool[2];  //默认都是flase

        static void Main(string[] args)
        {
            /* 开始游戏头 */
            GameHeadShow();

            /* 输入玩家 */
            InputPlayUser();

            /* 清屏 */
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}用A表示, {1}玩家用B表示", UserName1,UserName2);

            /* 初始化地图 */
            InitMaps();

            /* 展示地图 */
            PleanMapShow();

            
            while (UserOne < 99 && UserTwo < 99)
            {
                if (PlayTimes[0] == false && PlayTimes[1] == false)
                {
                    PlayGameUserOne();
                    PlayGameUserTwo();
                }
                else 
                {
                    if (PlayTimes[0])
                    {
                        PlayTimes[0] = false;
                        PlayGameUserOne();
                    }

                    if (PlayTimes[1])
                    {
                        PlayTimes[1] = false;
                        PlayGameUserTwo();

                    }
                }
            }//while

            PrintWin(UserOne, UserTwo);
        }

        public static void PrintWin(int one, int two)
        {
            if (one == two)
            {
                Console.WriteLine("平局");
            }
            else if (one >= 99)
            {
                Console.WriteLine("{0}赢了{1}", UserName1, UserName2);
            }
            else if (two >= 99)
            {
                Console.WriteLine("{0}赢了{1}", UserName2, UserName1);
            }
            Console.ReadKey(true);
        }
        /// <summary>
        /// Plean game head
        /// </summary>
        public static void GameHeadShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("************** FLAY CHESS GAME ************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************************");
        }

        public static void InputPlayUser()
        {
            if (UserName1 == null)
            {
                Console.Write("请输入玩家1姓名:");
                UserName1 = Console.ReadLine();
            }

            if (UserName2 == null)
            {
                Console.Write("请输入玩家2姓名:");
                UserName2 = Console.ReadLine();
                while (UserName1 == UserName2)
                {
                    Console.Write("请玩家2重新输入:");
                    UserName2 = Console.ReadLine();
                }
            }
            
        }

        /// <summary>
        /// init map
        /// </summary>
        public static void InitMaps()
        {
            int[] LuckTurn = { 6, 23, 40, 55, 69, 83 }; //幸运轮盘坐标
            for (int i = 0; i < LuckTurn.Length; i++)
            {
                g_Maps[LuckTurn[i]] = 1;    // 1 代表幸运轮盘
            }

            int[] LandMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 }; //地雷坐标
            for (int i = 0; i < LandMine.Length; i++)
            {
                g_Maps[LandMine[i]] = 2;    //地雷
            }

            int[] Pause = { 9, 27, 60, 93 };  //暂停坐标
            for (int i = 0; i < Pause.Length; i++)
            {
                g_Maps[Pause[i]] = 3;       //暂停
            }

            int[] TimeTunnel = { 20, 25, 45, 63, 72, 88, 90 };  //时空隧道坐标
            for (int i = 0; i < TimeTunnel.Length; i++)
            {
                g_Maps[TimeTunnel[i]] = 4;  //时空隧道 
            }
        }

        public static string PleanMap(int i)
        {
            string str = null;

            if (UserOne == UserTwo && UserOne == i)
            {
                /* 玩家1跟玩家2在同一个坐标上，并且都在同一点时输出 <>*/
                str = "<>";
            }
            else if (UserOne == i)  //玩家1 跟玩家2不在同一个坐标上
            {
                str = "A";   //画玩家A
            }
            else if (UserTwo == i)
            {
                str = "B"; //画玩家B
            }
            else
            {
                switch (g_Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "□";
                        break;

                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        str = "◎";
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        str = "☆";
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        str = "▲";
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        str = "☉";
                        break;
                }
            }

            return str;
        }

        public static void PleanMapShow()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("图列：幸运盘:◎\t地雷:☆\t暂停:▲时空隧道:☉");
            #region //画第一行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(PleanMap(i));
            }
            Console.WriteLine();    //换行
            #endregion

            #region //第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(PleanMap(i));
                Console.WriteLine();    //换行
            }
            #endregion

            #region //第二横行
            for (int i = 65; i > 35; i--)
            {
                Console.Write(PleanMap(i));
            }
            Console.WriteLine();    //换行
            #endregion

            #region //第二竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine(PleanMap(i));
            }
            #endregion

            #region //第三横行
            for (int i = 70; i < 100; i++)
            {
                Console.Write(PleanMap(i));
            }
            #endregion

            Console.WriteLine();

        }

        public static void PlayGameUserOne()
        {
            Random r = new Random();
            int RNumber = r.Next(1, 7);
            Console.WriteLine("{0}按任意键开始掷色子", UserName1);
            Console.ReadKey(true); //输入的字符，屏幕不显示
            Console.WriteLine("{0}掷出了{1}", UserName1, RNumber);
            UserOne += RNumber;
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine("{0}任意键开始行动", UserName1);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", UserName1);
            Console.ReadKey(true);
            if (UserOne == UserTwo)
            {
                Console.WriteLine("玩家{0}踩到了{1}，{2}退6格", UserName1, UserName2, UserName2);
                UserOne -= 6;
                ChangePos();
            }
            else
            {
                switch (g_Maps[UserOne])
                {
                    case 0:
                        Console.WriteLine("{0}踩到了□安全", UserName1);
                        Console.ReadKey();
                        break;

                    case 1:
                        Console.WriteLine("{0}踩到◎了幸运轮盘，1:交换位置，2:轰炸对方", UserName1);
                        string sel = null;
                        while (sel != "1" && sel != "2")
                        {
                            sel = Console.ReadLine();
                            switch (sel)
                            {
                                case "1":
                                    //交换位置
                                    UserOne += UserTwo;
                                    UserTwo = UserOne - UserTwo;
                                    UserOne -= UserTwo;
                                    break;

                                case "2":
                                    Console.WriteLine("{0}选择轰炸{1},{1}退6格", UserName1, UserName2, UserName2);
                                    UserTwo -= 6;
                                    ChangePos();
                                    break;

                                default:
                                    Console.WriteLine("1:交换位置，2:轰炸对方");
                                    break;
                            }
                        }

                        break;

                    case 2:
                        Console.WriteLine("{0}踩到☆了地雷", UserName1);
                        Console.ReadKey(true);
                        UserOne -= 6;
                        ChangePos();
                        break;

                    case 3:
                        Console.WriteLine("{0}踩到了▲暂停，暂停一回合", UserName1);
                        Console.ReadKey();
                        PlayTimes[0] = true;
                        break;

                    case 4:
                        Console.WriteLine("{0}踩到了☉时空隧道，前进10格", UserName1);
                        Console.ReadKey(true);
                        UserOne += 10;
                        ChangePos();
                        break;

                    default:
                        break;
                }//while
            }//else
            Console.Clear();
            PleanMapShow();
        }

        public static void PlayGameUserTwo()
        {
            Random r = new Random();
            int RNumber = r.Next(1, 7);
            Console.WriteLine("{0}按任意键开始掷色子", UserName2);
            Console.ReadKey(true); //输入的字符，屏幕不显示
            Console.WriteLine("{0}掷出了{1}", UserName2, RNumber);
            UserTwo += RNumber;
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine("{0}任意键开始行动", UserName2);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", UserName2);
            Console.ReadKey(true);
            if (UserOne == UserTwo)
            {
                Console.WriteLine("玩家{0}踩到了{1}，{2}退6格", UserName2, UserName1, UserName1);
                UserTwo -= 6;
                ChangePos();
            }
            else
            {
                switch (g_Maps[UserTwo])
                {
                    case 0:
                        Console.WriteLine("{0}踩到了□安全", UserName2);
                        Console.ReadKey();
                        break;

                    case 1:
                        Console.WriteLine("{0}踩到◎了幸运轮盘，1:交换位置，2:轰炸对方", UserName2);
                        string sel = null;
                        while (sel != "1" && sel != "2")
                        {
                            sel = Console.ReadLine();
                            switch (sel)
                            {
                                case "1":
                                    //交换位置
                                    UserOne += UserTwo;
                                    UserTwo = UserOne - UserTwo;
                                    UserOne -= UserTwo;
                                    break;

                                case "2":
                                    Console.WriteLine("{0}选择轰炸{1},{1}退6格", UserName2, UserName1, UserName1);
                                    UserTwo -= 6;
                                    ChangePos();
                                    break;

                                default:
                                    Console.WriteLine("1:交换位置，2:轰炸对方");
                                    break;
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("{0}踩到☆了地雷", UserName2);
                        Console.ReadKey(true);
                        UserTwo -= 6;
                        ChangePos();
                        break;

                    case 3:
                        Console.WriteLine("{0}踩到了▲暂停，暂停一回合", UserName2);
                        Console.ReadKey();
                        PlayTimes[1] = true;
                        break;
                       

                    case 4:
                        Console.WriteLine("{0}踩到了☉时空隧道，前进10格", UserName2);
                        Console.ReadKey(true);
                        UserTwo += 10;
                        ChangePos();
                        break;

                    default:
                        break;
                }//while
            }//else
            Console.Clear();
            PleanMapShow();

        }

        public static void ChangePos()
        {

            if (UserOne < 0)
            {
                UserOne = 0;
            }

            if (UserOne > 99)
            {
                UserOne = 99;
            }

            if (UserTwo < 0)
            {
                UserTwo = 0;
            }

            if (UserTwo > 99)
            {
                UserTwo = 99;
            }
        }
    }
}
