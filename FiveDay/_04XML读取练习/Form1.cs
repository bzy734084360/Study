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

namespace _04XML读取练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadXmlInTV(XElement list, TreeNodeCollection nodes)
        {
            foreach (XElement item in list.Elements())
            {
                TreeNode tn = null;
                //item.Name != null && (item.Name == "channel" || item.Name == "item")
                if (item.Elements().Count() > 0)
                {
                    string str = string.Empty;
                    if (item.Attribute("id") != null)
                    {
                        str = "id=" + item.Attribute("id").Value;
                    }
                    tn = nodes.Add(item.Name.LocalName + str);
                    LoadXmlInTV(item, tn.Nodes);
                }
                else
                {
                    tn = nodes.Add(item.Value);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = "11.xml";
            XDocument xdoc = XDocument.Load(fileName);
            LoadXmlInTV(xdoc.Root, tv.Nodes);
        }
    }
}
