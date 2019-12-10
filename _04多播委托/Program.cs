using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04多播委托
{
    public delegate int MyDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //MyDelegate md = T1;
            //md += T2;
            //md += T3;
            //md += T4;

            ////委托变量，赋值方法后，在调用这个委托变量的时候，必须判断是否为空
            //if (md != null)
            //{
            //    Console.WriteLine(md());
            //    Console.ReadKey();
            //}
            //ShowMyDel(ReturnInt);
            //使用系统中定义好的委托
            Action<int> t = new Action<int>(ShowInt);
            t(5);
            ShowDelegate(t, 5);
        }

        //public static void T1()
        //{
        //    Console.WriteLine("1");
        //}
        //public static void T2()
        //{
        //    Console.WriteLine("2");
        //}
        //public static void T3()
        //{
        //    Console.WriteLine("3");
        //}
        //public static void T4()
        //{
        //    Console.WriteLine("4");
        //}
        public static int T1()
        {
            return 1;
        }
        public static int T2()
        {
            return 2;
        }
        public static int T3()
        {
            return 3;
        }
        public static int T4()
        {
            return 4;
        }
        public static void ShowDelegate(Action<int> i, int x)
        {
            Action<int> md = new Action<int>(i);
            md(x);
        }

        public static void ShowMyDel(MyDelegate mdl)
        {
            mdl();
        }

        public static int ReturnInt()
        {
            return 5;
        }
        public static void ShowInt(int x)
        {
            Console.WriteLine(x);
        }

    }
}
