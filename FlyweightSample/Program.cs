using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FlyweightSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IgoChessman black1, black2, black3, white1, white2;
            IgoChessmanFactory factory;

            //获取亨元工厂对象
            factory = IgoChessmanFactory.GetInstance();

            //通过亨元工厂获取3颗黑子
            black1 = factory.GetIgoChessman("b");
            black2 = factory.GetIgoChessman("b");
            black3 = factory.GetIgoChessman("b");
            WriteLine("判断两颗黑子是否相同：" + (black1 == black2));

            //通过亨元工厂获取两颗白子
            white1 = factory.GetIgoChessman("w");
            white2 = factory.GetIgoChessman("w");

            WriteLine("判断两颗白子是否相同：" + (white1 == white2));

            //显示棋子
            //black1.Display();
            //black2.Display();
            //black3.Display();
            //white1.Display();
            //white2.Display();

            //显示棋子，同时设置棋子的坐标位置
            black1.Display(new Coordinates(13, 4));
            black2.Display(new Coordinates(3, 3));
            black3.Display(new Coordinates(1, 2));
            white1.Display(new Coordinates(5, 6));
            white2.Display(new Coordinates(9, 8));

            ReadLine();
        }
    }
}
