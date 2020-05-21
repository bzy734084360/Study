using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09委托练习
{
    public delegate void MyDel();

    public delegate string MyDelTwo(string str);
    class Program
    {
        static void Main(string[] args)
        {
            //DoSth(ShowTime);
            //Console.ReadKey();
            string[] st = { "asdasd", "asdasd", "gdfgdfg" };
            StringArray str = new StringArray();
            str.ChangeString(st, StringAddMsg);
            for (int i = 0; i < st.Length; i++)
            {
                Console.WriteLine(st[i].ToString());
            }
            Console.ReadKey();
        }

        public static void DoSth(MyDel mdl)
        {
            Console.WriteLine("吃早饭");
            Console.WriteLine("看书");
            Console.WriteLine("XXXXXX");
            Console.WriteLine("YYYYY");
            //Console.WriteLine("做什么事儿不确定");
            mdl();
        }

        public static void ShowTime()
        {
            Console.WriteLine(System.DateTime.Now.ToString());
        }

        public static void WriteText()
        {
            File.WriteAllText("1.txt", DateTime.Now.ToString());
        }

        public static string StringToUpper(string str)
        {
            return str.ToUpper();
        }

        public static string StringAddMsg(string str)
        {
            return "|" + str + "|";
        }
    }

    public class StringArray
    {
        /// <summary>
        /// 字符
        /// </summary>
        public string Msg { get; set; }

        public void ChangeString(string[] names, MyDelTwo mdl)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = mdl(names[i]);
            }
        }
    }
}
