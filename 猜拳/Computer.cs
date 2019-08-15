using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜拳
{
    /// <summary>
    /// 电脑
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 存储出拳内容
        /// </summary>
        public string FistName { get; set; }

        public int Play()
        {
            //伪随机数
            Random r = new Random();
            int num = r.Next(1, 4);
            switch (num)
            {
                case 1: this.FistName = "石头"; break;
                case 2: this.FistName = "剪刀"; break;
                case 3: this.FistName = "布"; break;
            }
            return num;
        }
    }
}
