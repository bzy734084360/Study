using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07事件三连击
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //threeClick.Mdl += DoSth;
            threeClick.Mdl += new MyDelegate(DoSthTwo);
        }
        void DoSthTwo()
        {
            MessageBox.Show("与委托三连击的区别,委托可以直接=，+=，-=，直接调用");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //事件不能直接调用
            //threeClick.Mdl();
        }
        //public void DoSth()
        //{
        //    MessageBox.Show("没什么太大变化");
        //}
    }
}
