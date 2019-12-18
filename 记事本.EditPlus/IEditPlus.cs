using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本.EditPlus
{
    /// <summary>
    /// 记事本插件规范接口
    /// </summary>
    public interface IEditPlus
    {
        /// <summary>
        /// 插件的名字
        /// </summary>
        string Name { get; }
        /// <summary>
        /// 记事本的文本框
        /// </summary>
        /// <param name="tb">文本框</param>
        /// <returns></returns>
        string ChangeString(TextBox tb);
    }
}
