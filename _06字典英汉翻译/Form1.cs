using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06字典英汉翻译
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //字典，单词作为建，中文意思作为值
        Dictionary<string, string> dic = new Dictionary<string, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //窗体的加载时间
            //读取文件
            string[] lines = File.ReadAllLines("1.txt", Encoding.Default);
            //遍历每一行
            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string chinese = string.Empty;
                for (int j = 0; j < words.Length - 1; j++)
                {
                    chinese += words[j];//把当前中文一行的意思累加
                }
                if (!dic.ContainsKey(words[0]))
                {
                    dic.Add(words[0], chinese);
                }
                else
                {
                    dic[words[0]] += chinese;
                }
            }
        }
        /// <summary>
        /// 翻译
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btntranslate_Click(object sender, EventArgs e)
        {
            //翻译按钮
            //
            if (dic.ContainsKey(txtBox.Text.ToLower()))
            {
                txtBoxResult.Text = dic[txtBox.Text.ToLower()];
            }
            else
            {
                txtBoxResult.Text = "该单词没有查询到！";
            }
        }
    }
}
