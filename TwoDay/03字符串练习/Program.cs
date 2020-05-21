using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 接收用户输入的字符串 并将字符串反转回去返回
            //Console.WriteLine("请输入内容");
            //string msg = Console.ReadLine();
            //msg = ChangrString(msg);
            //Console.WriteLine(msg);
            //Console.ReadKey();
            #endregion
            #region 接收用户输入的一句英文，将其中的单词以反序输出
            //Console.WriteLine("请输入一句英文");
            //string msg = Console.ReadLine();
            //string[] names = msg.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] = ChangrString(names[i]);
            //}
            //msg = string.Join(" ", names);
            //Console.WriteLine(msg);
            //Console.ReadKey();
            #endregion
            #region “2012年12月21日”从日期字符串中把年月日分别取出来
            //string date = "2012年12月21日";
            //string[] names = date.Split(new char[] { '年', '月', '日' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("年份是{0}", names[0]);
            //Console.WriteLine("月份是{0}", names[1]);
            //Console.WriteLine("日期是{0}", names[2]);
            //Console.ReadKey();
            #endregion
            #region 把csv文件中的联系人姓名和电话显示出来
            //第一步  读取文件
            //string[] lines = File.ReadAllLines("1.csv", Encoding.Default);

            ////第二部格式化转化

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    string[] txts = lines[i].Replace(",", "").Split(new char[] { '"' }, StringSplitOptions.RemoveEmptyEntries);
            //    Console.WriteLine("姓名是：{0}", txts[0] + txts[1]);
            //    Console.WriteLine("电话号码是：{0}", txts[2]);
            //}
            //Console.ReadKey();
            //显示效果
            #endregion
            #region 123-345--7----89------123----2把类似的字符串中重复符号“-”去掉
            //string str = "123-345--7----89------123----2";
            //string[] txt = str.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //str = string.Join("-", txt);
            //Console.WriteLine(str);
            //Console.ReadKey();
            #endregion
            #region 从文件路径中提取出文件名(包含后缀)

            //string path = "";
            //path = Path.GetFileName(path);

            #endregion
            #region ：“192.168.10.5[port=21,type=ftp]”

            //string str = "192.168.10.5[port=21]";
            //string[] lines = str.Split(new string[] { "[port=", ",type=", "]" }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("ip为：{0}", lines[0]);
            //Console.WriteLine("端口为{0}", lines[1]);
            //Console.WriteLine("服务是：{0}", lines.Length > 2 ? lines[2] : "htpp");
            //Console.ReadKey();
            #endregion
            #region 求员工工资文件中，员工最高的工资，最低工资，平均工资

            //读取文件
            //string[] lines = File.ReadAllLines("salary.txt", Encoding.Default);
            //string[] nameAndSalary = lines[0].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            //string maxName = nameAndSalary[0];
            //double maxSalary = Convert.ToDouble(nameAndSalary[1]);
            //string minName = nameAndSalary[0];
            //double minSalary = Convert.ToDouble(nameAndSalary[1]);
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    string[] nameSalary = lines[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            //    double salary = Convert.ToDouble(nameSalary[1]);

            //    if (maxSalary < salary)
            //    {
            //        maxSalary = salary;
            //        maxName = nameSalary[0];
            //    }
            //    if (minSalary > salary)
            //    {
            //        minSalary = salary;
            //        minName = nameSalary[0];
            //    }

            //}
            //Console.WriteLine("最高工资人是{0},工资是{1}", maxName, maxSalary);
            //Console.WriteLine("最低工资人是{0},工资是{1}", minName, minSalary);
            //Console.ReadKey();
            #endregion
        }

        private static string ChangrString(string msg)
        {
            char[] ch = msg.ToCharArray();
            char temp;
            for (int i = 0; i < ch.Length / 2; i++)
            {
                temp = ch[i];
                ch[i] = ch[ch.Length - 1 - i];
                ch[ch.Length - 1 - i] = temp;
            }
            return new string(ch);
        }
    }
}
