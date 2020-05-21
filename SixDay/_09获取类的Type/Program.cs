using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _09获取类的Type
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 获取Type的两种方式

            PerSon p = new PerSon();
            //获取类的Type
            Type tp = typeof(PerSon);
            //Type t = p.GetType();
            //获取类中所有的方法
            //MethodInfo[] meths = tp.GetMethods();
            //for (int i = 0; i < meths.Length; i++)
            //{
            //    Console.WriteLine(meths[i].Name);
            //}
            //MethodInfo meth = tp.GetMethod("Show");
            //Console.WriteLine(meth.Name);

            //获取所有的属性
            //PropertyInfo[] propers = tp.GetProperties();
            //for (int i = 0; i < propers.Length; i++)
            //{
            //    Console.WriteLine(propers[i].Name);
            //}

            Console.ReadKey();

            #endregion
        }
    }
    class PerSon
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        public void Show()
        {
            Console.WriteLine("哈哈");
        }
    }
}
