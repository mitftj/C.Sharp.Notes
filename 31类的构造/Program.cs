using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _31类的构造
{
    public class Person
    {
        public string Name { get; set; }

        public string Age { get; set; }
        public string  Id { get; set; }
        public string Conutry {  get; set; }
        public string City { get; set; }
        public Person()
        { 
            Conutry = "中国";
        }
        public Person( string name,string age,string id):this()//相当于合并，:this等于优先级，先执行this（）里面的
        {
           this.Name = name;
            Age = age;
            Id = id;
        }
        public Person(string name, string age, string id, string city) : this(name, age, id)
        {
            
           this. City = city;
        }

        public string GetInFo()
        { 
            return this.Name;   
        }
        public void ChangeGender(string gender)
        { 
            Person.Gender = gender;
        }
        public string ChangeGende()
        { 
            return Person.Gender;
        }
        //私有字段
        public static int weight;


        //静态属性
        public  static string Gender { get; set; }
        //静态方法
        public static  string GetAge()
        {
            Person person = new Person();
            return person.Age;//只能附加实例
        }
        public static void Add(int a ,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
    //静态类
    public static class MyClass
    {
        public static Person Person {  get; set; } 
        public static int Ate {  get; set; }
        static MyClass()//静态不能有带参数的构造
        { 
            //Person person = new Person();
            Name = "11111111";
        }
        public static string Name {  get; set; }
    }
    //普通类里面可以包含 静态属性 字段 方法
    //静态类里面不能包含普通的属性 字段 方法
    //静态类 静态属性 静态方法
    //
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();   
                Person person1 = new Person("小明","20","1357952468415","苏州");
            Console.WriteLine($"他的名字是{person1.Name}，他的年龄是{person1.Age}，" +
            $"他的身份证是{person1.Id}，他的城市是{person1.City},国籍是{person1.Conutry}" );
            Console.WriteLine("--------------------------------------------------------------");


            Person person = new Person();
                Person person2 = new Person();
            person.City = "苏州";
            person2.City = "南京";
            //类名+方法名调用 静态属性  方法
            Person.Gender = "男";//静态属性是共用的，一换全部换
            
            Console.WriteLine($"person的城市是{person.City}，person2的城市是{person2.City},person的性别是{Person.Gender}，person的性别是{Person.Gender}");
            person.ChangeGender("男");
            person2.ChangeGender("女");
            string result =person.ChangeGende();
            Console.WriteLine($"person的城市是{person.City}，person2的城市是{person2.City},person的性别是{result}，person的性别是{person2}");

            Person.Add(1, 2);//类名+方法名
            Console.WriteLine("------------------------静态类--------------------------------------");
            string mm = MyClass.Name;
            Console.WriteLine(mm);














        }
    }
}
