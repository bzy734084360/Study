using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02拉姆达表达式
{
    public delegate void MyDelegate();
    public delegate int MyAddDelegate(int num1, int num2);
    public delegate void MyDelegateString(string name);
    public delegate string MyDelegateStr(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = delegate () { Console.WriteLine("匿名函数"); };
            //myDelegate();
            //MyDelegate myDelegate1 = DoSth;
            //myDelegate1();//↑↓ 反编译为相同声明形式
            //MyDelegate myDelegate2 = new MyDelegate(DoSth);
            //myDelegate2();
            //拉姆达表达式
            MyDelegate mdl = () => { Console.WriteLine("拉姆达表达式"); };
            mdl();
            MyAddDelegate myAddDelegate = (int n1, int n2) => { return n1 + n2; };
            Console.WriteLine(myAddDelegate(5, 6));
            MyDelegateString myDelegateString = x => Console.WriteLine(x);
            myDelegateString("精简写法");
            MyDelegateStr myDelegateStr = xy => xy + "带返回值的拉姆达表达式";
            Console.WriteLine(myDelegateStr("简化"));
            Console.ReadKey();

        }

        public static void DoSth()
        {
            Console.WriteLine("做了一些事儿");
        }
    }
}
