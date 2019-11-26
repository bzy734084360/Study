using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07委托
{
    /// <summary>
    /// 数据类型
    /// </summary>
    public delegate void MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //Show(100);
            //DoSth("小样");
            //委托：是数据类型 将方法作为参数进行传递
            DoSth(Do);
            Console.ReadKey();
        }

        public static void DoSth(MyDelegate xx)
        {

        }
        public static void Do()
        {

        }

        //public static void Show(int num)
        //{
        //    Console.WriteLine(num + 100);
        //}

        //public static void DoSth(string name)
        //{
        //    Console.WriteLine(name + "好帅");
        //}
    }
    class Person
    {
        //字段
        private string name;
        //自动属性
        public string Age { get; set; }
        public string Name { get => name; set => name = value; }
    }
}
