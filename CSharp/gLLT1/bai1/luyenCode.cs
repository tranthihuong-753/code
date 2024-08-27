using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gLLT1.bai1
{
    internal class luyenCode
    {
        // THPTTD_114 - Mua nước
        static int vd1(int h, int u, int o, int n, int N )
        {

        }
        // SPNUM - Số đặc biệt
        static int vd2(int N, int k)
        {
            int y = 0;
            int i = 0;
            while(y < N)
            {
                y += (int)( Math.Pow(k, i));
                i++;
            }
            while (i != -1)
            {
                if ((y - (int)(Math.Pow(k, i))) >= N)
                {
                    y = y - (int)(Math.Pow(k, i));
                }
                i--;
            }
            return y;
        }
        // 
        static void Main(string[] args)
        {
            // Nhập vào h, u, o, n 
            string a = Console.ReadLine();
            string[] a1 = a.Split(' ');
            int[] a2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                a2[i] = int.Parse(a1[i]);
                Console.WriteLine(a2[i]);
            }
            int h = a2[0];
            int u = a2[1];
            int o = a2[2];
            int n = a2[3];
            //Nhập vào số lit nước 
            int N = int.Parse(Console.ReadLine());
            //thoe đề 
            Console.WriteLine(vd1(h, u, o, n, N));
        }
    }
}
