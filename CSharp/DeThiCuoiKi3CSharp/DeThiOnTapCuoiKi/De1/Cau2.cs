using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Câu 2 (2đ). Viết 1 hàm static nhập vào số nguyên dương n trong khoảng từ 2 đến 10. 
Nếu nhập sai thì nhập lại. Gọi hàm trong lớp chứa hàm Main() để kiểm tra. 
 */

namespace De1
{
    internal class Cau2
    {

        static void Main(string[] args)
        {
            int n = addint2to10();
            Console.WriteLine("n = " + n);
        }
        static int addint2to10()
        { 
            int output = 0;
            while (true)
            {
                Console.Write("Nhập vào số nguyên từ 2 đến 10.\nn = ");
                try
                {
                    output = int.Parse(Console.ReadLine());
                    if(output >= 2 && output <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nhập lại.");
                    }
                }catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return output;
        }
    }
}
