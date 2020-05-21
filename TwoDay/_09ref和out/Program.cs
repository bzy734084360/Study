using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ref和out
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref 可进可出，要赋初值
            //out 只出不进
            int number = 100;
            Show(ref number);
            Console.WriteLine(number);
            Console.ReadKey();
        }

        public static void Show(ref int num)
        {
            num = 1000;
        }
    }
}
