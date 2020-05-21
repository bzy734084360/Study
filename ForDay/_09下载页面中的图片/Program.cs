using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07下载页面中的图片
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计思路：获取页面的html字符串，检索出图片的标签，获取链接，下载图片
            WebClient wc = new WebClient();
            //确认网页编码格式
            //设置编码
            wc.Encoding = Encoding.GetEncoding("gb2312");
            //一张
            string html = wc.DownloadString("html");
            MatchCollection mts = Regex.Matches(html, "[]");
            foreach (Match item in mts)
            {
                if (item.Success)
                {
                    //Console.WriteLine(item.Groups[1].Value);
                    //下载图片
                    //获取下载图片的真实路径
                    string path = Path.Combine("http://gb.cri.cn", item.Groups[1].Value);
                    wc.DownloadFile(path, @"G:\大图\" + item.Groups[2].Value);
                }
            }
            Console.WriteLine("下载完成");
            Console.ReadKey();

        }
    }
}
