using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1_06082024
{

    internal class TeacherDonGio
    {
        static void Main(string[] args)
        {
            //Output();
            a();
        }
        // Su dung if else -> 
        static int InputInt_TryCatch()
        {
            Console.Write("n = ");
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n < 2 || n > 10)
                {
                    Console.WriteLine("n la so nguyen duong tu 2 den 10. \nBiet doc khong ha?\nKhong thi cut moe di \nChay ngay di cua Son Tung rat phu hop cho truong hop nay . \nKhong chinh to se hoa thanh nguoi va dam vo mom ban iu");
                    Console.WriteLine("Vui long nhap lai.");
                    InputInt_TryCatch();
                }
                return n;
            }
            catch (Exception e)
            {
                Console.WriteLine("Sao may ngu the.\nBan iu a\nBan co biet chang\nNao ban dang trong thung r*c");
                InputInt_TryCatch();
            }
            return 0;
        }
        // Ham in ra tu 1 den n
        static void Output()
        {
            int n = InputInt_TryCatch();
            for(int i = 0; i < n; i++)
            {
                Console.Write("SimID :");
                //string simID = Console.ReadLine();
                string simID = "";
                char c;
                do
                {
                    c = Console.ReadKey().KeyChar;
                    simID += c;
                }
                while (c == '#');
                Console.WriteLine("\nSimID: " + simID);
                //if (simID == "#") { 
                //    break; // Kết thúc khi người dùng nhập '#'
                //}
            }
        }
        static void a()
        {
            try
            {
                int a = 10;
                int b = new Random().Next(2) - 1;
                int result = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }

        }
    }

}
