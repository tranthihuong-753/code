 // https://luyencode.net/problem/vt03
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            string[] arrString = a.Split(' ');
            int[] arrInt = Array.ConvertAll(arrString, int.Parse);
            int i = 0;
            int index = 0;
            int max = arrInt[0];
            foreach (int x in arrInt)
            {
                if (max <= x)
                {
                    max = x;
                    index = i;
                }
                i++;
            }
            Console.WriteLine(index);
            Console.ReadLine();
        }
    }
}
