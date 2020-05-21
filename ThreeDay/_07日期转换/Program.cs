using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07日期转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("请输入日期:");
            string strDate = Console.ReadLine();
            string time = ConvertToDate(strDate);
            Console.WriteLine(time);
            Console.ReadKey();
        }

        private static string ConvertToDate(string strDate)
        {
            string dicTionary = "零0 一1 二2 三3 四4 五5 六6 七7 八8 九9";
            Dictionary<char, char> dic = new Dictionary<char, char>();
            string[] txt = dicTionary.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < txt.Length; i++)
            {
                if (!dic.ContainsKey(txt[i][0]))
                {
                    dic.Add(txt[i][0], txt[i][1]);
                }
            }
            char[] chs = strDate.ToCharArray();//字符串转字符数据
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < chs.Length; i++)
            {
                if (chs[i] == '十')
                {
                    if (!dic.ContainsKey(chs[i - 1]) && !dic.ContainsKey(chs[i + 1]))
                    {
                        result.Append("10");
                    }
                    else if (!dic.ContainsKey(chs[i - 1]) && dic.ContainsKey(chs[i + 1]))
                    {
                        result.Append("1");
                    }
                    else if (dic.ContainsKey(chs[i - 1]) && !dic.ContainsKey(chs[i + 1]))
                    {
                        result.Append("0");
                    }
                    //else if (dic.ContainsKey(chs[i - 1]) && dic.ContainsKey(chs[i + 1]))
                    //{

                    //}
                }
                else
                {
                    if (dic.ContainsKey(chs[i]))
                    {
                        result.Append(dic[chs[i]]);
                    }
                    else
                    {
                        result.Append(chs[i]);
                    }
                }
            }
            return result.ToString();
        }
    }
}
