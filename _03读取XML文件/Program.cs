using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _03读取XML文件
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("bank.xml");
            foreach (XElement item in xdoc.Root.Elements())
            {
                Console.WriteLine(item.Name);
                foreach (XElement element in item.Elements())
                {
                    Console.WriteLine(element.Name + "==" + element.Attribute("val").Value);
                }
            }
            Console.ReadKey();
        }
    }
}
