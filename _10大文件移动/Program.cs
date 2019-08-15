using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _10大文件移动
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取流
            using (FileStream fsRead = new FileStream(@"F:\电影\生化危机1.rmvb", FileMode.Open, FileAccess.Read))
            {
                //写入流
                using (FileStream fsWrite = new FileStream(@"D:\于富\基础加强练习\视频3练习\读写流测试\生化危机1.rmvb", FileMode.Create, FileAccess.Write))
                {
                    //每次读取大小是5M
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //实际（真正读取到的大小）
                    int r = fsRead.Read(buffer, 0, buffer.Length);
                    while (r > 0)
                    {
                        //写入
                        fsWrite.Write(buffer, 0, r);
                        Console.WriteLine("**");
                        //在读取
                        r = fsRead.Read(buffer, 0, buffer.Length);
                    }
                }
                Console.WriteLine("Ok");
                Console.ReadKey();

            }
        }
    }
}
