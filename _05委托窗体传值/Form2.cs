using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05委托窗体传值
{
    public delegate void SetValueForm(string str);
    public partial class Form2 : Form
    {
        SetValueForm st;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string str, SetValueForm ss) : this()
        {
            textBox1.Text = str;
            st = ss;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            st?.Invoke(textBox1.Text);
        }
    }
}
