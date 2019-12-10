using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06委托三连击
{
    public delegate void MyDelegate();
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        int num = 0;
        public MyDelegate mdl;
        private void Btn_Click(object sender, EventArgs e)
        {
            num++;
            if (num == 3)
            {
                //MessageBox.Show("已点击三次");
                num = 0;
                if (mdl != null)
                {
                    mdl();
                }
            }
        }
    }
}
