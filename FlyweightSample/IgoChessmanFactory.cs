using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FlyweightSample
{
    /// <summary>
    /// 围棋棋子工厂类，充当亨元工厂类，使用单例模式对其进行设计
    /// </summary>
    class IgoChessmanFactory
    {
        private static IgoChessmanFactory instance = new IgoChessmanFactory();
        private Hashtable ht;   //使用Hashtable来存储亨元对象，充当亨元池

        private IgoChessmanFactory()
        {
            ht = new Hashtable();
            IgoChessman black, white;
            black = new BlackIgoChessman();
            ht.Add("b", black);

            white = new WhiteIgoChessman();
            ht.Add("w", white);
        }

        //返回亨元工厂类的唯一实例
        public static IgoChessmanFactory GetInstance()
        {
            return instance;
        }

        //通过key获取存储在Hashtable中的亨元对象
        public IgoChessman GetIgoChessman(string color)
        {
            return (IgoChessman)ht[color];
        }
    }
}
