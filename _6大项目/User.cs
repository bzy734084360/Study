using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6大项目
{
    public class User
    {
        /// <summary>
        /// ID
        /// </summary>
        string _id;
        /// <summary>
        /// 姓名
        /// </summary>
        string _name;
        /// <summary>
        /// 密码
        /// </summary>
        string _password;
        /// <summary>
        /// 年龄
        /// </summary>
        string _age;
        /// <summary>
        /// 性别
        /// </summary>
        string _gender;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Age { get => _age; set => _age = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
