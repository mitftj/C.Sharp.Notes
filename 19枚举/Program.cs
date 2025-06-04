using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _19枚举.Program;

namespace _19枚举
{
    internal class Program
    {//枚举
        public enum Gender //类型 大驼峰命名 枚举类型的名字
        {
            男,
            女
        }
        public enum City
        {
            北京,
            上海,
            深圳,
            苏州,
            天津,
            安徽,
            广东,
            福建,
            湖北,
            湖南
        }
        public enum Week
        {
            星期一,
            星期二,
            星期三,
            星期四,
            星期五,
            星期六,
            星期日,
        }
        static void Main(string[] args)
        {

            //枚举
            //枚举类型 变量 =枚举类型.枚举值
            //int a = 10;



            City City1 = City.上海;
            Console.WriteLine(City1);//字符串类型
            //枚举转值要强转
            Console.WriteLine((int)City1);//值类型
            //等效
            //
            //字符串转枚举
            string mess = "广东";
            bool f = Enum.TryParse(mess, out City result);
            if (f)
            {

                Console.WriteLine(result);


            }
            //枚举转字符串
            string mess1 = City.天津.ToString();
            //枚举一般和switch连用

            Week week = Week.星期一;
            Console.WriteLine("请输入星期几");
            string mess2 = Console.ReadLine();
            bool work = Enum.TryParse(mess2, out week);//只要是数字都可以转成枚举
            //但是转成的不一定就是你预期的枚举
           bool wook1= Enum.IsDefined(typeof(Week), week);     //判断数字是不是枚举类型
            if (work&&wook1)
            {
                switch (week)
                {
                    case Week.星期一:
                        Console.WriteLine("星期一 语文");
                        break;
                    case Week.星期二:
                        Console.WriteLine("星期二 英语");
                        break;
                    case Week.星期三:
                        Console.WriteLine("星期叁 数学");
                        break;
                    case Week.星期四:
                        Console.WriteLine("星期四 道法");
                        break;
                    case Week.星期五:
                        Console.WriteLine("星期五 地理");
                        break;
                    case Week.星期六:
                        Console.WriteLine("星期六 政治");
                        break;
                    case Week.星期日:
                        Console.WriteLine("星期日 化学");
                        break;
                    default:
                        break;
                }
            }


            Console.ReadLine();

        }
    }
}
