using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _11反射调用方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Type tp = typeof(Person);
            //方法
            MethodInfo mt = tp.GetMethod("SayHello");
            object p = Activator.CreateInstance(tp);//创建Person对象 返回object类型对象
            int num = 1;
            mt.Invoke(p, new object[] { num });//调用了SayHello方法
            Console.ReadKey();
        }
    }

    public class Person
    {
        public void SayHello(int i)
        {
            Console.WriteLine($"调用 {i}");
        }
    }
}
