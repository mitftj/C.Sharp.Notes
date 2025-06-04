using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21引用数据类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //引用数据类型
            //值类型
            //栈:         
            int []nums=new int[] { 1,2,3,4,5,6,7,8,9};
            int[] nums1 = new int[5];
            nums1 = nums;
            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }
            int a = 10;
            int b;
            b = a;
            b = 50;
        }
    }
}
