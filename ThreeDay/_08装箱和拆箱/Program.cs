using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 100;
            //object obj = num;//值类型转换引用类型 装箱 ===不准确

            //string str = num.ToString();//不是装箱
            ////object obj = 100;
            //int number = (int)obj;//引用类型转换为值类型 拆箱 ===不准确
            ////double dou = (double)obj;//拆箱 报错

            int n = 10;
            object o = n;
            n = 100;
            Console.WriteLine(n + "," + (int)o);
            Console.ReadKey();
        }
    }
}
