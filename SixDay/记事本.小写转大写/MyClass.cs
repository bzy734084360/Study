using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 记事本.EditPlus;

namespace 记事本.小写转大写
{
    public class MyClass : IEditPlus
    {
        public string Name => "小写转大写";

        public string ChangeString(System.Windows.Forms.TextBox tb)
        {
            return tb.Text.ToUpper();
        }
    }
}
