using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32类的继承
{
    //类的继承
    public class Person
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
    }
    public class Student:Person
        //子类 继承与父类 目的
        //1.代码复用技术
        //优先执行父类构造后执行子类
        //父类私有化的字段子类无法访问和使用
    {
        public int StudentID {  get; set; }
        public Student() :base() //base指向
        {
        }
        public Student(int a,int b) :base(a) 
        {
            StudentID = b;
        }
        public override void Sport()//重写虚方法 ，父类的虚方法 子类重写 就调用子类的
        {
            base.Sport();
            Console.WriteLine("子类的运动方式打篮球");
        }
    }
    public class Teacher:Person
    {
        
    }
    public class Sport
    {
        public void SportSTtart(Person person)
        {
            person.Sport(); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(12,15);
            student.Speak();
            student.StudentID = 1;
            Console.WriteLine();
            //里氏替换原则 父类对象=子类的实例
            Person person = new Student();
        }
    }
}
