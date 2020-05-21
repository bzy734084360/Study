using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06委托三连击
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            threeClick.mdl = ShowTime;
        }
        public void ShowTime()
        {
            MessageBox.Show("显示时间" + DateTime.Now.ToString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            threeClick.mdl();
        }
    }
}
