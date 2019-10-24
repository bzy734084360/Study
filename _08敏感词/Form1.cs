using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08敏感词
{
    public partial class Form1 : Form
    {
        //List<string> listMod = new List<string>();//需要审核
        StringBuilder listMod = new StringBuilder();

        //List<string> listBanned = new List<string>();//禁止发贴
        StringBuilder listBanned = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //组合正则表达式
            //读取文件
            string[] lines = File.ReadAllLines("mg.txt", Encoding.Default);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] str = lines[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                if (str[1] == "{MOD}")//需要审核的
                {
                    listMod.Append(str[0] + "|");
                }
                else if (str[1] == "{BANNED}")//禁止发贴的
                {
                    listBanned.Append(str[0] + "|");
                }
            }
            //移除最后的|
            listMod.Remove(listMod.Length - 1, 1);
            listBanned.Remove(listBanned.Length - 1, 1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, listMod.ToString()))
            {
                MessageBox.Show($"需审核关键字:{textBox1.Text}");
            }
            else if (Regex.IsMatch(textBox1.Text, listBanned.ToString()))
            {
                MessageBox.Show($"禁止发贴关键字:{textBox1.Text}");
            }
            else
            {
                textBox2.Text = textBox1.Text;
            }
        }
    }
}
