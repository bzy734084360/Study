using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 文件
{
    class XmlFile : UserFile
    {
        public XmlFile(string name) : base(name) { }
        public override void OpenFile()
        {
            Console.WriteLine("{0}是XML文件，后缀名是{1}，可以用记事本和浏览器打开", this.FileName, this.Extension);
        }
    }
}
