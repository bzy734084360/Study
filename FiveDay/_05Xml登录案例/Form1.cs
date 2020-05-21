using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _05Xml登录案例
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        Dictionary<string, string> _dictUser = new Dictionary<string, string>();
        List<string> name = new List<string>();
        List<string> pwd = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("UserData.xml");
            LoadXmlInDict(xdoc.Root);
            //for (int i = 0; i < name.Count; i++)
            //{
            //    _dictUser.Add(name[i], pwd[i]);
            //}
        }

        /// <summary>
        /// 加载Xml数据到字典中
        /// </summary>
        private void LoadXmlInDict(XElement element)
        {
            foreach (XElement item in element.Elements())
            {
                _dictUser.Add(item.Element("name").Value, item.Element("password").Value);
                //if (item.Elements().Count() > 0)
                //{
                //    LoadXmlInDict(item);
                //}
                //else
                //{
                //    if (item.Name.LocalName == "name")
                //    {
                //        name.Add(item.Value);
                //    }
                //    else if (item.Name.LocalName == "password")
                //    {
                //        pwd.Add(item.Value);
                //    }
                //}
            }
        }

        private void Btnlogn_Click(object sender, EventArgs e)
        {
            //验证用户密码;
            if (!_dictUser.ContainsKey(txtName.Text))
            {
                MessageBox.Show("未找到该用户！");
            }
            else if (_dictUser[txtName.Text] != txtPwd.Text)
            {
                MessageBox.Show("输入的用户密码不正确！");
            }
            else
            {
                MessageBox.Show("登录成功！");
            }
        }
    }
}
