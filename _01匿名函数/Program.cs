using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01匿名函数
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDel(int num);
        public delegate int MyDelAdd(int num1, int num2);
        static void Main(string[] args)
        {
            DoSth(T);
            //匿名方法
            MyDelegate mdl = delegate () { Console.WriteLine("匿名方法"); };
            mdl();
            MyDel myDel = delegate (int number) { Console.WriteLine(number + "带参数的匿名函数"); };
            myDel(10);
            MyDelAdd myDelAdd = delegate (int num1, int num2) { return num1 + num2; };
            Console.WriteLine(myDelAdd(10, 5));

            Console.ReadKey();
        }
        public static void T()
        {

        }
        public static void DoSth(MyDelegate mdl)
        {
            mdl();
            Console.WriteLine("我做了什么事儿");
        }
    }
}
