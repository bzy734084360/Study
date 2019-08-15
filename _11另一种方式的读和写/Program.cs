using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11另一种方式的读和写
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 读取数据
            //using (StreamReader reader = new StreamReader("1.txt", Encoding.Default))
            //{
            //    //只读取一行 
            //    //string msg = reader.ReadLine();
            //    //string msg;
            //    //while ((msg = reader.ReadLine()) != null)
            //    //{
            //    //    Console.WriteLine(msg);
            //    //}
            //    //一直读取到流的末尾 
            //    //string msg = reader.ReadToEnd();
            //    //Console.WriteLine(msg);
            //    //while (!reader.EndOfStream)
            //    //{
            //    //    Console.WriteLine(reader.ReadLine());
            //    //}
            //}
            //Console.ReadKey();
            #endregion

            #region 写入数据

            //using (StreamWriter writer = new StreamWriter("one.txt"))
            //{
            //    writer.Write("这也可以啊");
            //}


            #endregion
        }
    }
}
