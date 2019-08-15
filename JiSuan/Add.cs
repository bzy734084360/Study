using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiSuan
{
    public class Add : SuanFa
    {
        //        类与类之间 可以用继承的方式表示
        //如果继承了 子类多数会调用父类的无参的构造函数
        public override int Result()
        {
            return this.Num1 + base.Num2;
        }
        public Add(int n1, int n2) : base(n1, n2) { }

    }
}
