using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 正则表达式字符说明

            //正则表达式 字符说明
            // . 表示除了\n意外的任意一个字符
            //[] 范围字符 例：[0-9]
            // | 或 
            // () 提高优先级
            //{}  前面的字符出现的次数
            // * 前面的表达式出现 0次或无限次
            // + 前面表达式出现1次或无限次
            // ? 前面表达式出现0次或一次
            // \d 数字 \D 非数字
            // \s 空白符 \S 非空白符
            // \w 非特殊字符 \W 特殊字符
            // ^  表示以什么开头
            // $ 表示以什么结尾

            #endregion

            #region 正则表达式案例练习

            //身份证 15位 或18位

            //[1-9][0-9]{13}([0-9]|[xX])  15位
            //[1-9][0-9]{16}([0-9]|[xX])  18位
            //([1-9][0-9]{13}([0-9]|[xX]))|([1-9][0-9]{16}([0-9]|[xX])) 15位或18位
            //写法一 ^[1-9][0-9]{14}([0-9]{2}[0-9Xx])?$
            //写法二 ^([1-9][0-9]{14}|[1-9][0-9]{16}[0-9X])$

            //验证身份证
            if (Regex.IsMatch("231181199412281856777", "^[1-9][0-9]{14}([0-9]{2}[0-9Xx])?$"))
            {
                Console.WriteLine("验证成功！");
            }
            else
            {
                Console.WriteLine("验证失败！");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
