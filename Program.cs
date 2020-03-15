using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //int a, b, c;
                //Calculate cal = new Calculate();
                //Console.WriteLine("请输入所要操作的第一个整数：");
                ////string input1 = Console.ReadLine();
                ////int firstInput = int.Parse(input1);
                //int firstInput = int.Parse(Console.ReadLine());
                //a = firstInput;
                //Console.WriteLine("请输入所要操作的第二个整数：");
                ////string input2 = Console.ReadLine();
                ////int secondInput = int.Parse(input2);
                //int secondInput = int.Parse(Console.ReadLine());
                //b = secondInput;
                //Console.WriteLine("请输入所要进行的运算(+、-、*、/其中一个)：");
                //string input3 = Console.ReadLine();
                //char thirdInput = char.Parse(input3);
                //c = thirdInput;
                //switch (c)
                //{
                //    case '+':
                //        cal.JiaFa(a, b); cal.Equals(a, b); break;
                //    case '-':
                //        cal.JianFa(a, b); cal.Equals(a, b); break;
                //    case '*':
                //        cal.ChengFa(a, b); cal.Equals(a, b); break;
                //    case '/':
                //        cal.ChuFa(a, b); cal.Equals(a, b); break;
                //}
                string s1, s2;
                int c;
                Calculate_new cal = new Calculate_new();
                Console.WriteLine("请输入所要操作的第一个字符串：");
                string input1 = Console.ReadLine();
                s1 = input1;
                Console.WriteLine("请输入所要操作的第二个字符串：");
                string input2 = Console.ReadLine();
                s2 = input2;
                Console.WriteLine("请输入所要进行的运算(+、-其中一个)：");
                string input3 = Console.ReadLine();
                char thirdInput = char.Parse(input3);
                c = thirdInput;
                switch (c)
                {
                    case '+':
                        cal.JiaFa(s1, s2); break;
                    case '-':
                        cal.JianFa(s1, s2); break;
                }
            }
            catch (Exception myex)
            {
                //Message.Tostring()中的Message是获取描述当前异常消息
                Console.WriteLine(myex.Message.ToString());
            }
        }
    }
}
