using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01文件类
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个文件夹(目录),在指定的路径
            //Directory.CreateDirectory("新建文件夹");
            //如果想要删除该目录中所有的内容则采用这个方法的第二个重载，true即可
            //Directory.Delete("新建文件夹", true);
            //判断该路径下是否有这个文件夹
            //Directory.Exists("新建文件夹");
            //获取该目录中所有文件的路径(包含文件名)
            //string[] path = Directory.GetFiles("新建文件夹", "*.txt");//获取该目录中的文本文件

            Console.ReadKey();
        }
    }
}
