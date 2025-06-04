using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26类02
{
    //公有属性私有字段1
    internal class Program
    {
        public class Person//类的定义  描绘出一个类
        {
            //静态特征 也叫字段--------公开 public ，私有化 private 
            public double height;//身高
            public double weight;//体重
            public string name;//姓名----私有化
                               // private int age;//年龄
            public string gender;//性别



            //属性-----公开的字段安全隐患比较大，不安全，需要使用属性保护字段，//字段还是字段，依旧是存数据的
            private int age;//c#2.0时代 的属性写法 带逻辑判断

            public int Age//属性--改名大驼峰命名法
            {
                get { return age; }//获取字段的值
                set
                {


                    while (true)
                    {
                        if (value < 0 || value > 100)

                        {
                            Console.WriteLine("你输入的年龄不合格");
                            Console.WriteLine("请重新输入你的年龄");
                            value = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            age = value;
                            break;
                        }
                    }




                }
            }
            //#3.0时代
            public string Countriy { get; set; }
            //public string NameID { get; set; }//有逻辑判断改成2.0时代
            private int nameID;

            public int NameID
            {
                get { return nameID; }
                set { nameID = value; }
            }


            //C#4.0
            public int dizhi => 50;
            public string adress = "江苏";



            //动态特征



            static void Main(string[] args)
            {

                Person person = new Person();
                Console.WriteLine("请输入你的年龄");

                person.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("你的年龄是：" + person.Age);
                person.Countriy = "中国";
                


            }
        }
    }
}
