using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20数组
{
    internal class Program
    {
        static void Main(string[] args)
        //数组类型 数组名= mew 数组类型[数组大]
        //数组是同一个数据类型 一个连续的内存空间表示一组数据
        {
            int[] nums = new int[5] { 1, 2, 3, 4, 5, };
            int[] nums2 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] nums3 = { 1, 2, 3, 4, 5, 6, 7 };
            int count = nums2.Length;//数组的大小
                                     //1.索引数组中元素的值
            int a = nums[4];
            //修改数组中的值
            nums[0] = 100;
            Console.WriteLine("nums[0]的值为" + nums[0]);
            int[] newNums = new int[5];
            for (int i = 0; i < newNums.Length; i++)
            {
                Console.WriteLine("遍历数组中的默认元素是" + newNums[i]);
            }
            //遍历
            for (int i = 0; i < nums.Length; i++)

            {
                nums[i] = nums[i] + 100;
                Console.WriteLine("遍历数组中的元素是" + nums[i]);
                if (nums2[i] > 3)
                {
                    newNums[i] = nums2[i];
                   
                }

            }
            for (int i = 0; i < newNums.Length; i++)
            {
                Console.WriteLine("遍历数组中的元素是" + newNums[i]);
            }
            //数组的排序
            int[] c = { 6,5,4,9,7,2,1};
            Array.Sort(c);//从小到大排序
            Array.Reverse(c);//反转
            foreach (int item in c)
            {
                ///item=1100;只能怪获取不能赋值
                Console.WriteLine("排序后的数组ints="+item);
            }
            //字符串类型数组
            string[] arr = new string[5] ;

            arr[0] = "设备01";
            arr[1] = "PLC1200";
            arr[2] = "KUKA 机器人";
            foreach (var item in arr)
            {
                if (item=="PLC1200")
                {
                    Console.WriteLine($"请关掉{item}该设备");
                }
            }
        }
    }
}
