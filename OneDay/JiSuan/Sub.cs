using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiSuan
{
    public class Sub : SuanFa
    {
        public Sub(int n1, int n2) : base(n1, n2) { }

        public override int Result()
        {
            return this.Num1 - this.Num2;
        }
    }
}
