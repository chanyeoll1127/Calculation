using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        /// <summary>
        /// 实现两个数相加
        /// </summary>
        public void JiaFa(int x, int y)
        {
            int z;
            z = x + y;
            Console.WriteLine("两数相加结果为：{0}", z);

        }
        /// <summary>
        /// 实现两个数相减
        /// </summary>
        public void JianFa(int x, int y)
        {
            int z;
            z = x - y;
            Console.WriteLine("两数相减结果为：{0}", z);
        }
        /// <summary>
        /// 实现两个数相乘
        /// </summary>
        public void ChengFa(int x, int y)
        {
            int z;
            z = x * y;
            Console.WriteLine("两数相乘结果为：{0}", z);
        }
        /// <summary>
        /// 实现两个数相除
        /// </summary>
        public void ChuFa(int x, int y)
        {

            int z;
            z = x / y;
            Console.WriteLine("两数相除结果为：{0}", z);
        }
        /// <summary>
        /// 判断两个整数是否相等
        /// </summary>
        /// <param name="x">第一个整数</param>
        /// <param name="y">第二个整数</param>
        public void Equals(int x, int y)
        {
            if (x == y)
                Console.WriteLine("两个整数相等。");
            else
                Console.WriteLine("两个整数不相等。");
        }
    }
}
