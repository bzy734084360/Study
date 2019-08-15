using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 判断用户输入的是否是邮箱
            //Console.WriteLine("请输入邮箱");
            //string email = Console.ReadLine();
            //int index = email.IndexOf("@");
            //if (index != -1)
            //{
            //    Console.WriteLine("是邮箱");
            //}
            //else
            //{
            //    Console.WriteLine("不是邮箱");
            //}
            //Console.ReadKey();
            #endregion

            #region {"aaa","b","cccc","dddd"} 判断字符串数组中最长的字符

            //string[] names = { "aaa", "b", "cccc", "dddd" };

            //string maxString = names[0];
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (maxString.Length < names[i].Length)
            //    {
            //        maxString = names[i];
            //    }
            //}
            //Console.WriteLine("名字最多的是{0}", maxString);
            //Console.ReadKey();
            #endregion

            #region {"中国","美国","巴西","澳大利亚"}

            //string[] names = { "中国", "美国", "巴西", "澳大利亚" };
            //for (int i = names.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(names[i] + " ");
            //}
            //Console.ReadKey();
            #endregion

            #region 判断某个字符串出现的次数 以及索引

            //string str = "传说在传智播客.net部门有个讲师叫小杨,小杨很帅,很纯洁,小杨是智慧和勇敢的化身.第一次听人这么说我不相信,于是我怀着试试看的心情来到了传智播客,见到了传说中的小杨。哇塞,小杨岂止是帅,简直就是帅的无法用言语来形容. ";

            //string keWords = "小杨";
            //int count = 0;
            //int index = 0;
            //while ((index = str.IndexOf(keWords, index)) != -1)
            //{
            //    count++;
            //    Console.WriteLine("{0}出现了{1},索引为{2}", keWords, count, index);
            //    index += keWords.Length;
            //}
            //Console.ReadKey();

            #endregion

            #region Gc手动回收
            //GC.Collect();
            #endregion
        }
    }
}
