using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 文件
{
    /// <summary>
    /// 文件父类
    /// </summary>
    public abstract class UserFile
    {
        public UserFile() { }

        public UserFile(string fileName)
        {
            //文件名
            this.FileName = Path.GetFileNameWithoutExtension(fileName);
            //扩展名 
            this.Extension = Path.GetExtension(fileName);
        }
        /// <summary>
        /// 文件扩展名
        /// </summary>
        public string Extension { get; set; }
        /// <summary>
        /// 文件名(无后缀)
        /// </summary>
        public string FileName { get; set; }

        public abstract void OpenFile();
    }
}
