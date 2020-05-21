using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05数字转大写案例
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1壹 2贰 3叁 4肆 5伍 6陆 7柒 8捌 9玖 0零 ";
            Dictionary<char, char> dict = new Dictionary<char, char>();
            string[] strNumber = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNumber.Length; i++)
            //{
            //    if (!dict.ContainsKey(strNumber[i][0]))
            //    {
            //        dict.Add(strNumber[i][0], strNumber[i][1]);
            //    }
            //}
            //foreach (KeyValuePair<char, char> item in dict)
            //{
            //    Console.WriteLine(item.Key + "|" + item.Value);
            //}
            //Console.ReadKey();
            #region 计算字符串中每种字母出现的次数(面试题)"Wellcome  ,to Chinaworld"；不区分大小写

            //string str = "Wellcome  ,to Chinaworld";
            //str = str.ToLower();
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    //判断当前的这个字符是不是字母
            //    if (char.IsLetter(str[i]))
            //    {
            //        if (!dic.ContainsKey(str[i]))
            //        {
            //            dic.Add(str[i], 1);
            //        }
            //        else
            //        {
            //            dic[str[i]]++;
            //        }
            //    }
            //}
            //foreach (KeyValuePair<char, int> item in dic)
            //{
            //    Console.WriteLine(item.Key + " 字母出现了：" + item.Value + " 次");
            //}
            //Console.ReadKey();
            #endregion
        }
    }
}
