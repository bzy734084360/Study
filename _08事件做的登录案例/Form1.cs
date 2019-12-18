using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08事件做的登录案例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmlogIn.Evt += new EventHandler(FrmLogin_Evt);
        }

        private void FrmLogin_Evt(object sender, EventArgs e)
        {
            //判断
            MyEventArgs me = e as MyEventArgs;
            if (me.User == "Admin" && me.Pwd == "123")
            {
                me.Flag = true;
            }
        }
    }
}
