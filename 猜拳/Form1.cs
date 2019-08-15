using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜拳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 石头按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnshitou_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            StartPlay(btn.Text);
        }

        //private void btnjiandao_Click(object sender, EventArgs e)
        //{
        //    //StartPlay();
        //}

        //private void btnbu_Click(object sender, EventArgs e)
        //{
        //    //StartPlay();
        //}

        private void StartPlay(string name)
        {
            //玩家
            Player p = new Player();
            int playnum = p.Play(name);
            this.lblPlayer.Text = name;
            //电脑
            Computer c = new Computer();

            int computerNum = c.Play();
            lblComputer.Text = c.FistName;

            //裁判
            CaiPan cp = new CaiPan();
            this.lblResult.Text = cp.Win(playnum, computerNum);
        }

    }
}
