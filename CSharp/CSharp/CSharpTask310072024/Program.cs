using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask310072024
{
    internal class Program
    {
        static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method 1, " + i);
                    // Do something
                    //Task.Delay(10).Wait();
                }
            });
        }
        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method 2, " + i);
                // Do something
                // Task.Delay(10).Wait();
            }
        }
        static void vd1()
        {
            _ = Method1();
            Method2();
            Console.ReadKey();
        }
        static async Task<int> Method3()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine("Method 1, " + i);
                    count++;
                }
            });
            return count;
        }
        static void Method4(int count)
        {
            Console.WriteLine("Total count is: " + count);
        }
        static async Task callMethod()
        {
            Task<int> task = Method3();
            Method2();
            int count = await task;
            Method4(count);
        }
        static void vd2()
        {
            callMethod().Wait();
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            vd2();
        }
    }
}
