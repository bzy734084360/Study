using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 登记案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.DengJi();
            //Console.ReadKey();

            //IDengJi dj = new Person();
            //dj.DengJi();
            //Console.ReadKey();
            //Car car = new Car();
            //car.DengJi();
            //Console.ReadKey();
            //IDengJi dj = new Car();
            //dj.DengJi();
            //Console.ReadKey();
            //House house = new House();
            //house.DengJi();
            //Console.ReadKey();
            //Show(new House());
            //Console.ReadKey();
        }

        public static void Show(IDengJi dj)
        {
            dj.DengJi();
        }
    }
}
