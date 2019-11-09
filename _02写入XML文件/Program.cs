using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02写入XML文件
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { Age = 18, Gender = "男", Name = "张三", Id = 11 });
            list.Add(new Person() { Age = 19, Gender = "女", Name = "龙太子", Id = 12 });
            list.Add(new Person() { Age = 30, Gender = "中", Name = "小黑", Id = 13 });
            list.Add(new Person() { Age = 20, Gender = "男", Name = "地主", Id = 14 });


            XDocument xdoc = new XDocument();
            //创建根元素
            XElement root = new XElement("Person");
            for (int i = 0; i < list.Count; i++)
            {
                XElement student = new XElement("student");
                student.SetAttributeValue("Id", list[i].Id);
                student.SetElementValue("name", list[i].Name);
                student.SetElementValue("gender", list[i].Gender);
                student.SetElementValue("age", list[i].Age);
                //添加到根节点
                root.Add(student);

            }
            //把根元素添加到文件中
            xdoc.Add(root);
            xdoc.Save("Person.xml");
        }
    }
    class Person
    {
        int _id;
        string _name;
        int _age;
        string _gender;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
