using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _35结构体
{
    // 定义一个名为 MyStruct 的结构体。结构体是值类型，类似于类，但有一些关键区别。
    public struct MyStruct
    {
        // 结构体不能有 无参数的构造函数。如果定义了构造函数，则必须带参数。
        // 如果不需要自定义构造函数，可以省略。
        //不写构造函数就默认有一个无参数的构造函数，并且不能重写
        /*
        public MyStruct(string a)
        {
            MyStructy = 10;
            name = "";
        }
        */

        // 定义一个公共属性 MyStructy，它是整数类型，并且具有 getter 和 setter 方法。
        public int MyStructy { get; set; }

        // 定义一个公共字段 name，它是字符串类型。
        // 注意：结构体中的字段不能有初始值赋值。
        public string name;
        // public string name="gggg";  // 不能 用初始值
        // 定义两个公共属性 x 和 y，它们是整数类型，并且具有 getter 和 setter 方法。
        public int x { get; set; }
        public int y { get; set; }

        // 定义一个公共方法 INitia，用于初始化结构体的成员变量。
        public void INitia()
        {
            MyStructy = 10;
            name = "张三";
        }

        // 定义一个公共方法 GetAge，返回一个固定的整数值 30。
        // 这个方法没有实际用途，仅作为演示。
        public int GetAge()
        {
            return 30;
        }
    }

    // 定义一个名为 PLC 的类，用于处理 MyStruct 类型的数据。
    public class PLC
    {
        // 声明一个 MyStruct 类型的私有字段 myStruct。
        private MyStruct myStruct = new MyStruct();

        // 定义一个公共方法 GetPoint，接受一个 MyStruct 参数并返回其 x 和 y 属性的字符串表示。
        // 此方法将传入的 MyStruct 对象复制到类的私有字段 myStruct 中。
        public string GetPoint(MyStruct my)
        {
            myStruct = my;
            return my.x.ToString() + my.y.ToString();
        }

        // 定义一个公共方法 GetString，计算 myStruct 的 x 和 y 属性各加 10 和 20 后的结果，
        // 并返回结果的字符串表示。
        public string GetString()
        {
            return ((myStruct.x + 10).ToString()) + ((myStruct.y + 20).ToString());
        }

        // 定义一个公共方法 GetMyStruct，创建一个新的 MyStruct 对象并设置其 x 和 y 属性，
        // 最后返回这个对象。
        public MyStruct GetMyStruct()
        {
            MyStruct my = new MyStruct() { x = 500, y = 600 };
            return my;
        }
    }

    // 定义程序入口点。
    internal class Program
    {
        static void Main(string[] args)
        {
            // 创建一个新的 MyStruct 实例。
            MyStruct my = new MyStruct();

            // 设置 my 的 MyStructy 属性为 10。
            my.MyStructy = 10;

            // 调用 my 的 INitia 方法进行初始化。
            my.INitia();

            // 设置 my 的 x 和 y 属性分别为 10 和 20。
            my.x = 10;
            my.y = 20;

            // 创建一个新的 PLC 实例。
            PLC pLC = new PLC();

            // 调用 pLC 的 GetPoint 方法，传入 my 作为参数，并忽略返回值。
            pLC.GetPoint(my);

            // 调用 pLC 的 GetMyStruct 方法获取一个新的 MyStruct 实例，并将其存储在 my1 中。
            MyStruct my1 = pLC.GetMyStruct();
        }
    }
}



