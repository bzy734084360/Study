using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07事件三连击
{
    public delegate void MyDelegate();
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        int num = 0;
        /// <summary>
        /// Event 事件关键词,如果在winform窗体中，写事件的时候，实际上可以不用定义未获，系统中有委托
        /// </summary>
        public event MyDelegate Mdl;
        //public event EventHandler Mdl;
        private void Btn_Click(object sender, EventArgs e)
        {
            num++;
            if (num == 3)
            {
                num = 0;
                //this.Mdl?.Invoke(this, e);
                this.Mdl?.Invoke();
            }
        }
    }
}
