using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightSample
{
    /// <summary>
    /// 黑色棋子类，充当具体亨元类
    /// </summary>
    class BlackIgoChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "黑色";
        }
    }
}
