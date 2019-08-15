using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05提取页面所有的邮箱
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = "file:///C:/Users/fishGrumpy/Desktop/%E9%A1%B5%E9%9D%A2%E6%88%AA%E5%8F%96%E9%82%AE%E7%AE%B1%E6%B5%8B%E8%AF%95.html";
            WebClient wc = new WebClient();
            //设置该页面以什么编码读取
            wc.Encoding = Encoding.UTF8;
            //从这个地址上把所有的子房湖窜下载下来
            string htmlString = wc.DownloadString(html);
            MatchCollection match = Regex.Matches(htmlString, "([0-9a-zA-Z_.-]+)(@[0-9a-zA-Z_.]+([.][a-zA-Z]+){1,2})");
            //遍历所有邮箱
            foreach (Match item in match)
            {
                //判断是否匹配成功了，可写可不写
                if (item.Success)
                {
                    //邮箱
                    //Console.WriteLine(item.Value);
                    Console.WriteLine(item.Groups[1].Value + "===" + item.Groups[2].Value);
                }

            }
            Console.WriteLine(match.Count);
            Console.ReadKey();
        }
    }
}
