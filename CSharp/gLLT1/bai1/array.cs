using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gLLT1.bai1
{
    internal class array
    {
        static void Main(string[] args)
        {
            /*
            // Mảng 1 chiều 
            //Nhập vào mảng n số nguyên 
            Console.Write("Số lượng phần tử của mảng là: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //Hiện lại mảng 
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
            */
            /*
            // Mảng 2 chiều 
            Console.Write("Nhập vào kích thước mảng 2 chiều ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] arr2 = new int[a, b];
            for(int i=0; i<a; i++)
            {
                for(int j=0; j < b; j++)
                {
                    arr2[i,j] = int.Parse(Console.ReadLine());
                }
            }

            //In ra mảng 2 chiều 
            Console.WriteLine("{");
            for (int i = 0; i < a; i++)
            {
                Console.Write("     {");
                for (int j = 0; j < b; j++)
                {
                    Console.Write(arr2[i, j]+"   ");
                }
                Console.WriteLine("} ,");
            }
            Console.Write("\n}");

            //Dùng foreach in ra mảng 2 chiều 
            Console.Write("{\n");
            foreach (int x in arr2){
                Console.Write(x + "   ");
            }
            Console.Write("\n}");

            Console.ReadKey();
            */
            /*

            //Mảng 2 chiều jogged 
            int[][] arr2Jogged = { 
                new int[] {1,2,3},
                new int[] {3,5,2,4,1},
            };
            Console.WriteLine("{");
            for (int i = 0; i < arr2Jogged.Length; i++)
            {
                Console.Write("     {");
                for (int j=0; j < arr2Jogged[i].Length; j++)
                {
                    Console.Write(arr2Jogged[i][j] + "   ");
                }
                Console.WriteLine("} ,");
            }
            Console.WriteLine("} ,");
            Console.ReadKey();
            */
        }

    }
}
