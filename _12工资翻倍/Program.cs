using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12工资翻倍
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过StreamReader和StreamWriiter 对工资文件进行操作

            //读
            using (StreamReader read = new StreamReader("gz.txt", Encoding.Default))
            {

                //写
                using (StreamWriter writer = new StreamWriter("gz1.txt", false, Encoding.Default))
                {
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        //获取所需数据
                        string[] salary = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        string txt = string.Format("{0}|{1}\n", salary[0], Convert.ToInt32(salary[1]) * 2);
                        writer.Write(txt);

                    }//end while
                }//end writer
            }//end read
            Console.WriteLine("搞定！");
            Console.ReadKey();

        }//end void main
    }//end Program
}
