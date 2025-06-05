using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33类的抽象
{
    public abstract class Person
    {
        public Person()
        {

        }
        public Person(int a)
        {
            Id = a.ToString();
        }
        public string Name { get; set; }

        public string Age { get; set; }
        public string Id { get; set; }
        public string Conutry { get; set; }
        public string City { get; set; }
        private int Icord_Poword = 33161513;
        public void Speak()
        {
            Console.WriteLine("会说话");
        }
        public virtual void Sport()//虚方法 
        {
            Console.WriteLine("父类的方法会跑步");
        }

        //抽象方法 强制实现的 方法 不能有方法体 必须在抽象类里，抽象类里可以没有抽象方法
        //抽象类没有方法体不能实例化
        public abstract void Run();
        public abstract void Run1();
        public abstract void Run2();
        public abstract void Run3();
    }
    public class Student : Person
    {
        public override void Run()
        {
            Console.WriteLine("学生跑步");
        }

        public override void Run1()
        {
            Console.WriteLine("学生跑步1");
        }

        public override void Run2()
        {
            Console.WriteLine("学生跑步2");
        }

        public override void Run3()
        {
            Console.WriteLine("学生跑步3");
        }
    }
    public class Teacher : Person
    {
        public override void Run()
        {
            Console.WriteLine("老师跑步");
        }

        public override void Run1()
        {
            Console.WriteLine("老师跑步1");
        }

        public override void Run2()
        {
            Console.WriteLine("老师跑步2");
        }

        public override void Run3()
        {
            Console.WriteLine("老师跑步3");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();//抽象类无法实现他自己
            //p.Age;
            List<Person> list = new List<Person>();
            Person person = new Student();

            Person person1 = new Teacher();
            list.Add(person);
            list.Add(person1);
            foreach (var item in list)
            {
                item.Run();
            }

        }
    }
}
