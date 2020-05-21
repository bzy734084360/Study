using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 总结
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Show();
            Student st = new Student();
            st.Show();
            Console.ReadKey();
        }
    }

    public class Person
    {
        public virtual void Show()
        {
            Console.WriteLine("我是人，别害怕");
        }
    }

    public class Student : Person, IsAndF
    {
        public override void Show()
        {
            Console.WriteLine("我是学生");
        }

        public void Fly()
        {
            Console.WriteLine("我是学生我会飞");
        }

        public void Swim()
        {
            Console.WriteLine("我是学生我会游泳");
        }
    }

    interface IFly
    {
        void Fly();
    }

    interface ISwim
    {
        void Swim();
    }
    interface IsAndF : IFly, ISwim
    {

    }
}
