using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

/*
Câu 2 (2đ). Viết 1 hàm static nhập vào số nguyên dương n trong khoảng từ 2 đến 10. 
Nếu nhập sai thì nhập lại. Gọi hàm trong lớp chứa hàm Main() để kiểm tra. 
 */

namespace De1_06082024
{
    internal class Cau2
    {
        static void Main(string[] args)
        {
            //InputInt_Tao();
        }
        // Nhập vào số nguyên dương n trong khoảng từ 2 đến 10.
        // Nếu nhập sai thì nhập lại.
        // Su dung Try Catch va De Quy ->
        // Su dung if else -> 
        static int InputInt_TryCatch()
        {
            Console.Write("n = ");
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                if(n < 2 || n > 10)
                {
                    Console.WriteLine("n la so nguyen duong tu 2 den 10. \nBiet doc khong ha?\nKhong thi cut moe di \nChay ngay di cua Son Tung rat phu hop cho truong hop nay . \nKhong chinh to se hoa thanh nguoi va dam vo mom ban iu");
                    Console.WriteLine("Vui long nhap lai.");
                    InputInt_TryCatch();
                }
                return n;
            }
            catch(Exception e)
            {
                Console.WriteLine("Sao may ngu the.\nBan iu a\nBan co biet chang\nNao ban dang trong thung r*c");
                InputInt_TryCatch();
            }
            return 0;
        }
        static int InputInt_IfElse()
        {
            while (true) // Lặp liên tục cho đến khi nhận được giá trị hợp lệ
            {
                Console.Write("n = ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int n))// Kiểm tra xem đầu vào có phải là số nguyên không
                {
                    if (n >= 2 && n <= 10)
                    {
                        return n; // Trả về giá trị hợp lệ
                    }
                    else
                    {
                        Console.WriteLine("n phải là số nguyên từ 2 đến 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Giá trị nhập vào không phải là số nguyên.");
                }

                Console.WriteLine("Vui lòng nhập lại."); // Yêu cầu nhập lại
            }
        }
        // Nhap vao so nguyen . DK : 2 <= x <= 10 
        static int InputInt_Tao()
        {
            int x;
            do
            {
                Console.Write("Nhap vao so nguyen : ");
                x = int.Parse(Console.ReadLine());
            } while (x < 2 || x > 10);
            return x;
        }
    }
}
