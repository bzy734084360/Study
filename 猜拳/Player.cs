using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜拳
{
    /// <summary>
    /// 玩家
    /// </summary>
    public class Player
    {
        /// <summary>
        /// 存储出拳内容
        /// </summary>
        public string FistName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int Play(string name)
        {
            //把内容存起来
            this.FistName = name;
            int num = 0;
            switch (this.FistName)
            {
                case "石头": num = 1; break;
                case "剪刀": num = 2; break;
                case "布": num = 3; break;
            }
            return num;
        }
    }
}
