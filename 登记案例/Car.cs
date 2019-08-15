using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 登记案例
{
    public class Car : IDengJi
    {
        /// <summary>
        /// 对象或者接口都可使用
        /// </summary>
        public void DengJi()
        {
            Console.WriteLine("车登记了");
        }
        /// <summary>
        /// 显示实现接口(通过接口调用)
        /// </summary>
        void IDengJi.DengJi()
        {
            Console.WriteLine("车又登记了");
        }
    }
}
