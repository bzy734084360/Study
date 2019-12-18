using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _12几个常用的方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly ass = Assembly.LoadFile(@"D:\于富\基础加强练习\视频6练习\SixVideo\UserClass\bin\Debug\UserClass.dll");
            Type tPer = ass.GetType("UserClass.Person");
            Type tStd = ass.GetType("UserClass.Student");
            Type tFly = ass.GetType("UserClass.IFly");

            //第四个
            //判断tFly是否为抽象，或判定是否为接口
            Console.WriteLine(tFly.IsAbstract);
            //第三个
            //判断 tper 是否为tstd的子类
            //bool result = tPer.IsSubclassOf(tStd);
            //Console.WriteLine(result);
            //第二个方法
            //判断objStd是不是tPer的子类
            //object objStd = Activator.CreateInstance(tStd);
            //bool result = tPer.IsInstanceOfType(objStd);
            //Console.WriteLine(result);


            //第一个方法
            //tStd 能否赋值给tPer
            //bool result = tPer.IsAssignableFrom(tStd);
            //Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
