using JiSuan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请您输入第一个数字");
            int num1 = Convert.ToInt32(Console.ReadLine());//异常处理
            Console.WriteLine("请输入第二个数字");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入运算符+-*/");
            string opt = Console.ReadLine();
            SuanFa sf = GetSuanFaByNumberAndOpt(opt, num1, num2);
            if (sf != null)
            {
                Console.WriteLine(sf.Result());
                Console.ReadKey();
            }
        }

        private static SuanFa GetSuanFaByNumberAndOpt(string opt, int num1, int num2)
        {
            SuanFa sf = null;
            //判断符号
            switch (opt)
            {
                case "+": sf = new Add(num1, num2); break;
                case "-": sf = new Sub(num1, num2); break;
            }
            return sf;
        }
    }
    //public class Chengfa : SuanFa
    //{
    //    public override int Result()
    //    {
    //        return this.Num1 * this.Num2;
    //    }
    //}
}
