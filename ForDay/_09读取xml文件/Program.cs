using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _09读取xml文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //加载该文件
            XDocument xdoc = XDocument.Load("first.xml");
            //获取XML文件中的根元素
            XElement root = xdoc.Root;
            //Console.WriteLine(root);//获取所有的元素
            //Console.WriteLine(root.Name);//获取根元素的名字
            //获取根元素中所有的直接子元素
            IEnumerable<XElement> eles = root.Elements();

            foreach (XElement item in eles)//遍历class
            {
                Console.WriteLine(item.Name + "|" + item.Attribute("clsid").Value);
                foreach (XElement stu in item.Elements())//遍历student
                {
                    Console.WriteLine(stu.Name + "|" + stu.Attribute("id").Value);
                    Console.WriteLine(stu.Element("name").Value);
                    Console.WriteLine(stu.Element("gender").Value);
                    Console.WriteLine(stu.Element("age").Value);
                }
            }
            Console.ReadKey();

        }
    }
}
