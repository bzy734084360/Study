using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜拳
{
    /// <summary>
    /// 裁判
    /// </summary>
    public class CaiPan
    {
        /// <summary>
        /// 裁判
        /// </summary>
        /// <param name="player">玩家出拳结果</param>
        /// <param name="computer">电脑出拳结果</param>
        /// <returns></returns>
        public string Win(int player, int computer)
        {
            string result = string.Empty;
            switch (player - computer)
            {
                case -1:
                case 2:
                    result = "玩家赢了";
                    break;
                case 1:
                case -2:
                    result = "电脑赢了";
                    break;
                default:
                    result = "平局了";
                    break;
            }
            return result;
        }
    }
}
