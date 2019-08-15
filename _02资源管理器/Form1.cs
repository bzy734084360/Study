using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _02资源管理器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddTv_Click(object sender, EventArgs e)
        {
            //添加根节点
            tv.Nodes.Add(textBox2.Text);

            //添加子节点
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //添加子节点
            //获取当前选中的节点
            TreeNode tn = tv.SelectedNode;
            tn.Nodes.Add(textBox3.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "Demo";
            LoadDirection(path, tv.Nodes);
        }


        private void LoadDirection(string path, TreeNodeCollection nodes)
        {
            //加载所有的目录 
            string[] dires = Directory.GetDirectories(path);
            for (int i = 0; i < dires.Length; i++)
            {
                string name = Path.GetFileNameWithoutExtension(dires[i]);
                TreeNode tn = nodes.Add(name);
                LoadDirection(dires[i], tn.Nodes);
            }
            //加载每个目录中的文件
            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                string fileName = Path.GetFileNameWithoutExtension(files[i]);
                TreeNode tn1 = nodes.Add(fileName);
                tn1.Tag = files[i];
            }
        }

        private void Tv_DoubleClick(object sender, EventArgs e)
        {
            if (tv.SelectedNode.Tag != null)
            {
                txt.Text = File.ReadAllText(tv.SelectedNode.Tag.ToString(), Encoding.Default);
            }
        }
    }
}
