using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08委托定义
{
    public delegate int MyDel(int str);
    class Program
    {
        static void Main(string[] args)
        {
            //Test(Show);
            //Console.ReadKey();
            //Console.WriteLine(Add(T1));
            MyAdd ma = new MyAdd();
            Console.WriteLine(Add(ma.AddNumber));
            Console.ReadKey();
        }
        //public static string Show(string str)
        //{
        //    return str + "测试";
        //}
        //public static void Test(MyDel myDel)
        //{
        //    Console.WriteLine(myDel("Str"));

        //}
        public static int Add(MyDel mdl)
        {
            return mdl(200);
        }
        public static int T1(int number)
        {
            number = number + 100;
            return number;
        }
    }
    public class MyAdd
    {
        public int AddNumber(int num)
        {
            return num + 10;
        }
    }
}
