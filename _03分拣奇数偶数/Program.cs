using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03分拣奇数偶数
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 3, 4, 45, 66, 67, 68, 55 };
            List<int> listOdd = new List<int>();//奇数
            List<int> listEven = new List<int>();//偶数
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    listEven.Add(list[i]);
                }
                else
                {
                    listOdd.Add(list[i]);
                }
            }
            for (int i = 0; i < listEven.Count; i++)
            {
                Console.WriteLine(listEven[i]);
            }
            Console.WriteLine("=============");
            for (int i = 0; i < listOdd.Count; i++)
            {
                Console.WriteLine(listOdd[i]);
            }
            Console.ReadKey();
        }
    }
}
