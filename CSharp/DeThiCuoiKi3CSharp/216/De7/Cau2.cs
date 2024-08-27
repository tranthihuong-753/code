using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De7
{
    internal class Cau2
    {
        static void Main(string[] args)
        {
            int x = input_n();
            //Console.WriteLine(x);
        }
        static int input_n()
        {
            int n;
            while (true)
            {
                Console.Write("Nhập vào số nguyên dương n : ");
                string help_n = Console.ReadLine();
                try
                {
                    n = int.Parse(help_n);
                    if(n > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("!!! Số nguyên có giá trị không thỏa đáng ( âm / 0 ).");
                    }
                }catch (Exception e)
                {
                    Console.WriteLine("!!! " + e.Message);
                }
            }
            return n;
        }
    }
}
