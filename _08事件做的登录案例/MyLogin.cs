using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08事件做的登录案例
{

    public partial class MyLogin : UserControl
    {
        public MyLogin()
        {
            InitializeComponent();
        }
        public event EventHandler Evt;
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            //判断用户名和密码是否正确
            //若正确，背景颜色变成红色，否则是绿色
            //要做什么操作，不清楚
            MyEventArgs mea = new MyEventArgs();
            mea.User = txtUser.Text;
            mea.Pwd = txtPassword.Text;
            this.Evt?.Invoke(this, mea);
            if (mea.Flag)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
        }

    }

    public class MyEventArgs : EventArgs
    {
        private string user;
        public string User { get => user; set => user = value; }
        private string pwd;
        public string Pwd { get => pwd; set => pwd = value; }
        public bool Flag { get => flag; set => flag = value; }
        /// <summary>
        /// 
        /// </summary>
        private bool flag;
        public MyEventArgs()
        {
            this.Flag = false;
        }
    }
}
