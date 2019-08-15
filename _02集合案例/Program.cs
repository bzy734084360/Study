using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02集合案例
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 合并两个集合 去除重复项

            //List<string> listOne = new List<string>() { "a", "b", "c", "d" };
            //List<string> listTwo = new List<string> { "c", "d", "e", "f" };

            //for (int i = 0; i < listTwo.Count; i++)
            //{
            //    if (!listOne.Contains(listTwo[i]))
            //    {
            //        listOne.Add(listTwo[i]);
            //    }
            //}
            //for (int i = 0; i < listOne.Count; i++)
            //{
            //    Console.WriteLine(listOne[i]);
            //}
            //Console.ReadKey();

            #endregion
            #region 随机生成10个1-100之间的数放到List中,要求这个10个数不能重复 并且都是偶数
            //Random rd = new Random();
            //List<int> list = new List<int>();
            //while (list.Count < 10)
            //{
            //    int num = rd.Next(1, 101);
            //    if (!list.Contains(num) && num % 2 == 0)
            //    {
            //        list.Add(num);
            //    }
            //}
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.ReadKey();
            #endregion
        }
    }
}
