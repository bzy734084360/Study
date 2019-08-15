using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04验证邮箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //xiaoming@126.com

            //正则表达式验证邮箱案例
            Console.WriteLine("请输入邮箱：");
            string email = Console.ReadLine();
            string zzEamil = "[0-9a-zA-z_.-]+@[0-9a-zA-z_-]+([.][a-zA-Z]+){1,2}";
            //静态方法
            bool result = Regex.IsMatch(email, zzEamil);
            if (result)
            {
                Console.WriteLine("是邮箱");
            }
            else
            {
                Console.WriteLine("不是邮箱");
            }
            Console.ReadKey(true);
        }
    }
}
