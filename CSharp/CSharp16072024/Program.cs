using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp16072024
{
    internal class Program
    {
        // Text 
        // Hàm ghi string vào tệp text 
        static void vd1(string file, dynamic text)
        {
            try
            {
                // Ghi tiep vao cuoi file AppendAllText
                // "File.WriteAllText" -> xoa toan bo noi dung trong file va ghi noi dung moi vao 
                File.AppendAllText(file, text);
                Console.WriteLine($"Đã ghi thêm vào tệp {file} thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi khi ghi vào tệp: {ex.Message}");
            }
        }
        static void vd1_arr(string file, dynamic array)
        {
            try
            {
                // "WriteAllLines" -> de xoa noi dung cu va them noi dung moi vao 
                // Chi dung duoc cho mang 1 chieu 
                File.AppendAllLines(file, array);
                Console.WriteLine($"Đã ghi mảng vào tệp {file} thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi khi ghi vào tệp: {ex.Message}");
            }
        }
        // Hàm đọc tệp CSV
        static void vd1a(string file)
        {
            try
            {
                if (File.Exists(file))
                {
                    string readText = File.ReadAllText(file);  // Đọc nội dung của tệp
                    Console.Write("Nội dung của tệp:");
                    Console.WriteLine(readText);  // Hiển thị nội dung
                }
                else
                {
                    Console.WriteLine($"Tệp {file} không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi khi đọc tệp: {ex.Message}");
            }
        }
        // Hàm lọc Input(chuỗi muốn lọc, kiểu dữ liệu muốn giữ)
        static dynamic vd1b(dynamic x, string kieuDuLieuOut)
        {
            string input = x.ToString();
            string result = "";

            // Chuyen chuoi thanh chu thuong 
            switch (kieuDuLieuOut.ToLower())
            {
                case "int":
                case "double":
                case "float":
                    result = new string(input.Where(char.IsDigit).ToArray());
                    break;
                case "string":
                case "char":
                    result = new string(input.Where(char.IsLetter).ToArray());
                    break;
                default:
                    throw new ArgumentException("Kiểu dữ liệu không hợp lệ. Hãy chọn 'so', 'chu', hoặc 'so va chu'.");
            }

            return result;
        }
        static void Main(string[] args)
        {
            string file = "text.txt";
            //string text = "\nDog cat";
            //text = " eat";
            //vd1(file, text);
            // Tao mang 1 chieu 
            string[] arrString = {"one ", "two ", "three "};
            vd1_arr(file, arrString);
            vd1a(file);
        }
    }
}
