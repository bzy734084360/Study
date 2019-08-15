using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //string msg = "飞流之下三千尺";
            ////字符串转字节数据
            //byte[] by = System.Text.Encoding.UTF8.GetBytes(msg);
            ////字节数组转字符换
            //System.Text.Encoding.UTF8.GetString(by);

            //File 读写小文件

            //把字符串写入到文件中

            //using (FileStream fs = new FileStream("1.txt", FileMode.Create, FileAccess.Write))
            //{
            //    string msg = "文能提笔控萝莉";
            //    byte[] by = System.Text.Encoding.UTF8.GetBytes(msg);
            //    fs.Write(by, 0, by.Length);
            //}
            //Console.WriteLine("哦买雷电嘎嘎闹！！！");
            //Console.ReadKey();
            //fs.Close();//关闭流
            //fs.Flush();//清除缓冲区
            //fs.Dispose();//释放占用的资源

            //以流的方式读取数据
            //using (FileStream fs = new FileStream("1.txt", FileMode.Open, FileAccess.Read))
            //{
            //    byte[] buffer = new byte[fs.Length];
            //    fs.Read(buffer, 0, buffer.Length);
            //    string str = System.Text.Encoding.UTF8.GetString(buffer);
            //    Console.WriteLine(str);
            //}
            //Console.ReadKey();

        }
    }
}
