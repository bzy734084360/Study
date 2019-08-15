using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine(nums[2]);
            //Dictionary<>
        }
    }
    public class Person
    {
        public string[] names = { "卡卡西", "大神丸", "李莫愁" };
        public string this[int index]
        {
            get { return this.names[index]; }
        }

        public string this[string key]
        {

        }
    }
}
