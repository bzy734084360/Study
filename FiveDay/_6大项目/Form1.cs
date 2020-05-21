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

namespace _6大项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //读取所有的用户信息
            LoadUser();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        private void LoadUser()
        {
            List<User> list = new List<User>();//存储对象数据的
            XDocument xdoc = XDocument.Load("haodongxi.xml");
            //解析XML放入对象
            foreach (XElement user in xdoc.Root.Elements())
            {
                list.Add(new User()
                {
                    Id = user.Attribute("id").Value,
                    Name = user.Element("name").Value,
                    Gender = user.Element("gender").Value,
                    Age = user.Element("age").Value,
                    Password = user.Element("password").Value
                });
            }
            //获取数据;绑定dgv数据
            dgv_user.DataSource = list;//绑定数据
            if (dgv_user.Rows.Count > 0)
            {
                dgv_user.SelectedRows[0].Selected = false;//禁止第一行选中
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //获取姓名
            User newUser = new User()
            {
                Id = id.Text,
                Name = name.Text,
                Gender = man.Checked ? "男" : "女",
                Age = age.Text,
                Password = password.Text
            };
            XDocument xdoc = XDocument.Load("haodongxi.xml");
            XElement element = new XElement("user");
            element.SetAttributeValue("id", id.Text);
            element.SetElementValue("name", name.Text);
            element.SetElementValue("gender", man.Checked ? "男" : "女");
            element.SetElementValue("age", age.Text);
            element.SetElementValue("password", password.Text);
            xdoc.Root.Add(element);
            xdoc.Save("haodongxi.xml");
            MessageBox.Show("注册成功");
            LoadUser();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmDelete_Click(object sender, EventArgs e)
        {
            //判断是否有选中行
            if (dgv_user.SelectedRows.Count > 0)
            {
                //获取ID
                string id = dgv_user.SelectedRows[0].Cells[0].Value.ToString();
                //根据ID 在XML中查找user标签
                XDocument xdoc = XDocument.Load("haodongxi.xml");
                XElement root = xdoc.Root;
                //根据id 的值去根元素下找所有的user标签 条件筛选
                List<XElement> ele = root.Elements("user").Where(x => x.Attribute("id").Value == id).ToList();
                //for (int i = 0; i < ele.Count; i++)
                //{
                //    ele[i].Remove();
                //}
                ele.Remove();
                xdoc.Save("haodongxi.xml");
                MessageBox.Show("删除成功");
                LoadUser();
            }
            else
            {
                MessageBox.Show("请选中删除行");
            }

        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAlter_Click(object sender, EventArgs e)
        {
            if (dgv_user.SelectedRows.Count > 0)
            {
                XDocument xdoc = XDocument.Load("haodongxi.xml");

                XElement root = xdoc.Root;
                XElement xele = root.Elements("user").Where(x => x.Attribute("id").Value == id.Text).Single();
                xele.SetElementValue("name", name.Text);
                xele.SetElementValue("age", age.Text);
                xele.SetElementValue("gender", man.Checked ? "男" : "女");
                xele.SetElementValue("password", password.Text);
                //保存
                xdoc.Save("haodongxi.xml");
                MessageBox.Show("修改成功！");
                LoadUser();
            }
            else
            {
                MessageBox.Show("请选中修改行！");
            }
        }
        /// <summary>
        /// 选中修改项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //
            id.Text = dgv_user.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dgv_user.SelectedRows[0].Cells[1].Value.ToString();
            man.Checked = dgv_user.SelectedRows[0].Cells[2].Value.ToString() == "男" ? true : false;
            woman.Checked = dgv_user.SelectedRows[0].Cells[2].Value.ToString() == "女" ? true : false;
            age.Text = dgv_user.SelectedRows[0].Cells[3].Value.ToString();
            password.Text = dgv_user.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
