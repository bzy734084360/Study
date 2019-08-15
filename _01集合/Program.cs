using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组 集合

            List<int> list = new List<int>();
            list.Add(78);
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            list.Insert(2, 100);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            //list.RemoveAt(2);//根据索引来移除
            //list.ToArray();//把集合转换成数组
            Console.WriteLine("===");
            Console.ReadKey();
            //int[] nums = { 1, 2, 3, 4 };
            //list.AddRange(nums);
            //List<int> list1 = new List<int>();
            //list.AddRange(list1);
            //list.Clear();
            //list.Contains(3);//判断集合是否包含该元素
            //list.Count;//集合的个数

        }
    }
}
