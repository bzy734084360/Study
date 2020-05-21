using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件
{
    class AviFile : UserFile
    {
        public override void OpenFile()
        {
            Console.WriteLine("{0}是视频文件，后缀名是{1}，可以用快播打开", this.FileName, this.Extension);
        }
        public AviFile(string name) : base(name) { }
    }
}
