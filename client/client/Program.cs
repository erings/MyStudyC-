﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace client
{
    class Program
    {
        static void Main()
        {
            try
            { 
                //新建客户端套接字
                TcpClient tcpclnt = new TcpClient();
                Console.WriteLine("连接......");

                //连接服务器
                tcpclnt.Connect("127.0.0.1", 8001);
                Console.WriteLine("已连接");
                Console.WriteLine("请输入要传输的字符串");

                //读入字符串
                String str = Console.ReadLine();

                //得到客户端流
                Stream stm = tcpclnt.GetStream();

                //发送字符串
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("传输中。。。");

                //接收从服务器返回信息
                byte[] bb = new byte[100];
                int k = stm.Read(bb, 0, 100);

                //输出服务器返回信息
                for (int i = 0; i < k; i++)
                {
                    Console.Write(Convert.ToChar(bb[i]));
                }

                //关闭客户端连接
                tcpclnt.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine("Error...." + e.StackTrace);
            }
        }
    }
}
