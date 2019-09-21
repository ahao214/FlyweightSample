using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FlyweightSample
{
    /// <summary>
    /// 围棋棋子类，充当抽象亨元类
    /// </summary>
    abstract class IgoChessman
    {
        public abstract string GetColor();

        public void Display(Coordinates coord)
        {
            //WriteLine("棋子颜色：" + this.GetColor());
            WriteLine("棋子颜色：{0},棋子位置：{1},{2}", this.GetColor(), coord.X, coord.Y);
        }
    }
}
