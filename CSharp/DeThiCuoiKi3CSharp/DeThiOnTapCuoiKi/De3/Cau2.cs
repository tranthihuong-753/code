using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Câu 2 (2đ). Viết 1 hàm static nhập vào số nguyên dương n trong khoảng từ 2 đến 10. 
Nếu nhập sai thì nhập lại. Gọi hàm trong lớp chứa hàm Main() để kiểm tra. 
 */
namespace De3
{
    internal class Cau2
    {
        static int input_n()
        {
            string x;
            int y;
            while (true)
            {
                Console.Write("Nhaap vao so nguyen n (2->10) . n = ");
                x = Console.ReadLine();
                try
                {
                    y = int.Parse(x);
                    if(y >= 2 && y <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("So nguy nhap vao phai >= 2 va <=10.");
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return y;
        }
        static void Main(string[] args)
        {
            input_n();
        }
    }
}
