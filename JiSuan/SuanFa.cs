using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiSuan
{
    public abstract class SuanFa
    {
        //每个类中都有一个无参的构造函数，如果写有参的构造函数，那么该类的无参构造函数需实现
        /// <summary>
        /// 自动属性
        /// </summary>
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public SuanFa(int n1, int n2)
        {
            this.Num1 = n1;
            this.Num2 = n2;
        }

        public SuanFa()
        {

        }

        public abstract int Result();
    }
}
