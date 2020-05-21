using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06页面提取职位信息
{
    class Program
    {
        static void Main(string[] args)
        {
            ////提取职位信息
            //string html = "https://search.51job.com/list/180200,000000,0000,00,9,99,%2B,2,1.html?lang=c&stype=1&postchannel=0000&workyear=99&cotype=99&degreefrom=99&jobterm=99&companysize=99&lonlat=0%2C0&radius=-1&ord_field=0&confirmdate=9&fromType=&dibiaoid=0&address=&line=&specialarea=00&from=&welfare=";
            //WebClient wc = new WebClient();
            //string htmlString = wc.DownloadString(html);
            ////string test = "<a target=\"_blank\" titlSe=\"行政助理\" href=\"http://www.job.carrefour.com.cn/sc/show_job_detail.php?jobid=114997965\" onmousedown=\"jobview('114997965');\">";
            //string test = "<a\\s*target=\"_blank\"\\s*title=\"(.+)\"\\s*href=";
            //string test1 = "<a\\s*target=\"_blank\"\\s*title=\"(.+)\"\\s*href=\".*\"";
            //string test2 = "<a\\s*target=\"_blank\"\\s*title=\"(.+)\"\\s*href=\".*\"\\s*onmousedown=\".*\">";
            ////提取职位正则表达式：
            //MatchCollection matches = Regex.Matches(htmlString, test2);
            //foreach (Match item in matches)
            //{
            //    if (item.Success)
            //    {
            //        Console.WriteLine(item.Groups[1].Value);
            //    }
            //}
            //Console.WriteLine($"共{matches.Count}个职位");
            //Console.ReadKey(true);
            string html = "https://www.baidu.com/";
            WebClient wc = new WebClient();
            string htmlString = wc.DownloadString(html);
            byte[] bt = Encoding.Default.GetBytes(htmlString);
            string htmlEnString = Encoding.UTF8.GetString(bt);

        }
    }
}
