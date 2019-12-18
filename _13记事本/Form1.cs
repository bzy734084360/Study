using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 记事本.EditPlus;

namespace _13记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 事件

        private void Form1_Load(object sender, EventArgs e)
        {
            //主程序直接去Lib目录中搜索DLL文件
            //第一步，获取当前程序运行的目录
            string name = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Lib");
            //获取所有Lib文件夹中的dll文件
            string[] files = Directory.GetFiles(name, "*.dll");
            //MessageBox.Show(files[0]);
            //遍历所有的dll文件路径
            foreach (string item in files)
            {
                //反射获取dll
                Assembly ass = Assembly.LoadFile(item);
                //获取所有公共的Type
                Type[] types = ass.GetExportedTypes();
                Type tpIEdit = typeof(IEditPlus);//获取接口的Type
                for (int i = 0; i < types.Length; i++)
                {
                    //判断每个type对象是否实现了接口
                    if (tpIEdit.IsAssignableFrom(types[i]) && !types[i].IsAbstract)
                    {
                        //创建接口实例
                        IEditPlus iedit = Activator.CreateInstance(types[i]) as IEditPlus;
                        //显示到视图下面
                        ToolStripItem tsi = tsm.DropDownItems.Add(iedit.Name);
                        //将该接口存储到tsi对象的tag中
                        tsi.Tag = iedit;
                        //给菜单注册单机事件
                        tsi.Click += new EventHandler(tsi_Click);
                    }
                }
            }

        }

        private void tsi_Click(object sender, EventArgs e)
        {
            ToolStripItem tsi = sender as ToolStripItem;
            IEditPlus iedits = tsi.Tag as IEditPlus;
            textBox1.Text = iedits.ChangeString(textBox1);
        }

        #endregion
    }
}
