using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _10获取程序集中的Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过路径获取该程序的程序集
            Assembly ass = Assembly.LoadFile(@"D:\于富\基础加强练习\视频6练习\SixVideo\MyClass\bin\Debug\MyClass.dll");

            //调用程序集中的方法
            Type tp = ass.GetType("MyClass.Person");
            //Person的对象 
            object obj = Activator.CreateInstance(tp);
            //Person中的方法
            MethodInfo mt = tp.GetMethod("DoSth");
            mt.Invoke(obj, null);//相当于p.DoSth();



            //Type[] types = ass.GetExportedTypes();
            //Type tp = ass.GetType(types[0].FullName);
            //Console.WriteLine(tp.Name);

            ////获取该程序集中所有的类的type
            //Type[] tps = ass.GetTypes();
            ////获取所有公共的类的type
            ////ass.GetExportedTypes();
            ////该类的命名空间 
            //Console.WriteLine(tps[0].FullName);
            ////该程序集的信息
            //Console.WriteLine(tps[0].Assembly.FullName);
            //for (int i = 0; i < tps.Length; i++)
            //{
            //    Console.WriteLine(tps[i].Name);
            //    //如何获取程序集中的公共方法
            //    MethodInfo[] mts = tps[i].GetMethods();
            //    for (int j = 0; j < mts.Length; j++)
            //    {
            //        Console.WriteLine(mts[j].Name);
            //    }
            //}
            Console.ReadKey();
        }
    }
}
