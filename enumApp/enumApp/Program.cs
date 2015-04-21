﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace enumApp
{
    class Program
    {
        //声明一个枚举类型weekday,基类为int，访问范围为public
        public enum Weekday
        {
            Sun, Mon, Tue, Wed, Thu, Fri, Sat
        }

        public static void Main()
        {
            //用枚举类型Weekday声明变量并赋初值
            Weekday wd1 = Weekday.Mon;
            Console.WriteLine("每周的工作日从{0}开始", wd1);
            Weekday wd2 = Weekday.Fri;
            Console.WriteLine("到{0}结束", wd2);

            //枚举类型变量用于计算
            Console.WriteLine("每周有{0}个工作日", wd2 - wd1 + 1);
            Console.WriteLine();

            //枚举类型变量作为函数的参数
            Console.WriteLine("Mon之后是{0}", NextDay(Weekday.Mon));
            Console.WriteLine();

            //使用枚举类型的GetNames()方法
            foreach (string s1 in Weekday.GetNames(typeof(Weekday)))
            {
                Console.Write(s1 + " ");
            }
            Console.WriteLine();

            //从命令行读取枚举类型变量的值
            Console.Write("今天是星期几？");
            Weekday wd3 = (Weekday)Weekday.Parse(typeof(Weekday), Console.ReadLine());
            Console.WriteLine("明天是{0}", NextDay(wd3));

            //比较枚举类型的值
            Console.Write("体育课在星期几？");
            wd1 = (Weekday)Weekday.Parse(typeof(Weekday), Console.ReadLine());
            Console.Write("物理实验在星期几？");
            wd2 = (Weekday)Weekday.Parse(typeof(Weekday), Console.ReadLine());
            if (wd2.CompareTo(wd1) == 0)
            {
                Console.WriteLine("糟糕，在同一天");
            }
            else
            {
                Console.WriteLine("没事，不在同一天");
            }

            Console.ReadLine();

        }

        //功能：得到某日的下一日（星期几）
        //参数：
        //         wd：枚举类型Weekday
        //返回值：枚举类型Weekday
        private static Weekday NextDay(Weekday wd)
        {
            Weekday wdnext;
            if (wd == Weekday.Sun)
            {
                wdnext = Weekday.Mon;
            }
            else
            {
                wdnext = wd + 1;
            }

            return wdnext;
        }
    }
}
