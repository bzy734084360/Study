using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * 
 * 
 */
namespace 文件
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入文件名，包含后缀名");
            string file = Console.ReadLine();
            UserFile uf = GetFile(file);
            if (uf != null)
            {
                uf.OpenFile();
                Console.ReadKey();
            }
        }

        private static UserFile GetFile(string file)
        {
            UserFile uf = null;
            switch (Path.GetExtension(file).ToLower())//字符串转小写
            {
                case ".txt": uf = new TxtFile(file); break;
                case ".avi": uf = new AviFile(file); break;
                case ".xml": uf = new XmlFile(file); break;
            }
            return uf;
        }
    }
}
