using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03拉姆达表达式练习
{
    public delegate int MyDelegateInt(int n1, int n2, int n3);
    class Program
    {
        static void Main(string[] args)
        {
            //Show((x, y, z) => x + y - z);
            //Console.ReadKey();
            List<int> list = new List<int>() { 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> number = list.Where(x => x > 5);
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static void Show(MyDelegateInt mdl)
        {
            int result = mdl(10, 20, 30);
            Console.WriteLine(result);
        }
    }
}
