using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 登记案例
{
    public class Person : IDengJi
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void DengJi()
        {
            Console.WriteLine("人登记");
        }
    }
}
