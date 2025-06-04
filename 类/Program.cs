using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _26类01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 类的介绍
            //类 是 物以类聚，综合了那一类的特征（比方说 汽车 机器人 PLC 电脑）类型或者是类别的//共同特征//
            // 汽车类  人类 PLC类
            //类有一定的特征 分为静态特征 动态特征
            //汽车类的静态特征：轮胎 车窗 发动机........
            //汽车的动态特征：能跑 鸣笛 

            #endregion
            //类 名 （实列）=new (开新的空间) 类名 ();
            Person person = new Person();
            person.name = "张三";
            person.height = 180;
            person.weight = 100;
            person.gender = "男";
            person.age = 20;
            Console.WriteLine("你的名字是：" + person.name);
            Console.WriteLine("你的体重是：" + person.weight);
            Console.WriteLine("你的年龄是：" + person.age);
            Console.WriteLine("你的身高是：" + person.height); 
            Console.WriteLine("你的性别是：" + person.gender);
           
            Person person1= new Person();
            person1.name = "李四";
            person1.height = 170;
            person1.weight = 120;
            person1.gender = "女";
            person1.age = 23;
            Console.WriteLine("新人的名字是：" + person1.name);
            Console.WriteLine("新人的体重是：" + person1.weight);
            Console.WriteLine("新人的年龄是：" + person1.age);
            Console.WriteLine("新人的身高是：" + person1.height);
            Console.WriteLine("新人的性别是：" + person1.gender);
            
            List<Person> list_Person = new List<Person>();
            Dictionary<string, Person> keyValuePairs = new Dictionary<string, Person>();
            keyValuePairs["穿越者001"]= person;
            keyValuePairs["穿越者002"] = person1;



            list_Person.Add(person); 
            list_Person.Add((Person)person1);
            int a = 0;
            foreach (var item in list_Person)
            {
               a+= item.age;
            }
            int b = a / list_Person.Count;
            Console.WriteLine($"他们的平均年龄是{b}");
            keyValuePairs["穿越者001"].age = 30;
            person.age = 23;
            //-----------------------------------------------------------------------
            List<Person> list_person = new List<Person>();



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入你的名字");
                Person person2= new Person();//新建一个空间
                person2.name=Console.ReadLine();
                Console.WriteLine("请输入你的年龄");
                person2.age =int.Parse(Console.ReadLine());
                Console.WriteLine("请输入你的性别");
                person2.gender = Console.ReadLine();
                Console.WriteLine("请输入你的体重");

                list_person.Add(person2);


            }

          List<Person>pers=  list_person.Where(c => c.age >= 18 && c.age <= 20).ToList();

            foreach (var item in pers)
            {
                Console.WriteLine(item.name); 
            }
           

        }

        //访问修饰符+class关键字+类  名+大驼峰命名法
        public class Person//类的定义  描绘出一个类
        {
            //静态特征 也叫字段--------小驼峰命名法
            public double height;//身高
            public double weight;//体重
            public string name;//姓名
            public int age;//年龄
            public string gender;//性别

            //动态特征

        }








    }
}

