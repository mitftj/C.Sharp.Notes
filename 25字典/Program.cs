using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25字典
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //字典 检索 -----》对应的内容
            //键 key --------value
            //键值对的关系
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                ["设备1"] = "生产的内容是芯片型号：X25686 采取工艺号为：TY12167",
                ["上相机"] = "IP 193.297.396.1.1",
                ["设备3"] = "生产的内容是 芯片型号：X87226 采取工艺号为：GT12359"

            };
            //移除
            dic.Remove("设备1");
           // dic["上相机"] = "111111111111";//改值
            string value = dic["上相机"];
            dic.Remove ("上相机");
            dic.Add("下相机",value);
            
            dic.TryGetValue("下相机",out string mm);
            if (dic.TryGetValue("下相机", out value))
            {
                Console.WriteLine(value);
            }
            foreach (var item in dic.Keys)
            {
                Console.WriteLine(item);//键
                Console.WriteLine(dic[item]);//值
            }
            foreach (var item in dic.Values)
            {
                Console.WriteLine(item);//值
            }
        }
    }
}
