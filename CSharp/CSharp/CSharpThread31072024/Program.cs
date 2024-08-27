using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpThread31072024
{
    internal class Program
    {
        static void thread1(string txt)
        {
            //for (int i = 0; i<100; i++)
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(txt + " - " + i);
            }
        }
        static void vd1()
        {
            Thread t = new Thread(() =>
            {
                thread1("Thread 1");
            });
            t.Start();

            Thread t2 = new Thread(() =>
            {
                thread1("Thread 2");
            });
            t2.Start();

            Thread t3 = new Thread(() =>
            {
                thread1("Thread 3");
            });
            t3.Start();

            Console.ReadLine();
        }
        static void thread2(string txt)
        {
            int sum = 0;
            for (int i = 0; i < 20; i++)
            {
                //Console.WriteLine(txt + " - " + i);
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void vd2()
        {
            Thread t = new Thread(() =>
            {
                thread1("Thread 1");
            });
            t.Start();
            Thread t2 = new Thread(() =>
            {
                thread2("Thread 2");
            });
            t2.Start();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //vd1();
            vd2();
        }
    }
}
