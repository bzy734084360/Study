using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04键值对
{
    class Program
    {
        static void Main(string[] args)
        {
            //键要唯一，不能重复
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("卡卡西", 23);
            dict.Add("乔峰", 32);
            dict.Add("小笼包", 1000);
            //遍历所有的键
            foreach (string item in dict.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============");
            foreach (var item in dict.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======");
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine(item.Key + "|" + item.Value);
            }

            Console.ReadKey();
        }
    }
}
