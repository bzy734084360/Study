using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10写入xml文件
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument();
            //根元素
            XElement root = new XElement("person");

            //子元素
            XElement stu = new XElement("student");

            //设置student元素属性的值
            stu.SetAttributeValue("id", "110");
            stu.SetElementValue("name", "乔峰");
            stu.SetElementValue("gender", "男");
            stu.SetElementValue("age", "40");
            //把子元素添加到根元素
            root.Add(stu);
            //把根元添加到文档中
            xdoc.Add(root);
            //保存
            xdoc.Save("myXml.xml");
        }
    }
}
