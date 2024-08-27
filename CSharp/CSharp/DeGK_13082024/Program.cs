using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeGK_13082024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, sinhvien> mydict = svCMC(2);
            GhiBangSim(mydict);
        }
        // Hàm nhập dữ liệu và trả về Dictionary
        static Dictionary<int, sinhvien> svCMC(int n)
        {
            Dictionary<int, sinhvien> svs = new Dictionary<int, sinhvien>();
            int count = 1; // biến đếm bản ghi 
            // Mảng chứa các màu tùy chọn
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Random random = new Random();
            while (count <= n)
            {
                Console.ForegroundColor = colors[random.Next(colors.Length)];
                Console.WriteLine($"BẢN GHI CHO SINH VIEN {count}");
                // Nhập ID 
                Console.Write("ID: ");
                string ID = Console.ReadLine();
                // Nhập Name
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                // Ngày sinh 
                Console.Write("Birthday: ");
                Console.Write("NgaySinh (yyyy-MM-dd): ");
                DateTime NgaySinh;
                if (!DateTime.TryParse(Console.ReadLine(), out NgaySinh))
                {
                    Console.WriteLine("Ngày kích hoạt không hợp lệ.");
                    continue;
                }
                // Tạo đối tượng và thêm vào Dictionary
                sinhvien sv = new sinhvien(ID, Name, NgaySinh);
                svs[count] = sv;
                count++;
            }
            return svs;
        }
        static void run_svCMC()
        {
            Dictionary<int, sinhvien> mydict = svCMC(5); 
        }
        // Ham ghi vao bang sinhvien 
        static string strCon = "Data Source = HuongDuong ; Initial Catalog = Sales ; Integrated Security = True";
        static void GhiBangSim(Dictionary<int, sinhvien> dict1)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            foreach (var sim in dict1)
            {
                try
                {
                    con.Open();
                    string txtSQLcreate = "INSERT INTO sinhvien (ID, Name, Birthday) VALUES(@ID, @Name, @Birthday)"; // Neu dung $ them thang value vao thi loi -> So khong du bao mat -> Dung @ 
                    SqlCommand cmd = new SqlCommand(txtSQLcreate, con);//lưu trữ câu lệnh SQL cần thực thi cùng với kết nối đến cơ sở dữ liệu.(data + @dich + tim duong)
                    cmd.Parameters.AddWithValue("@ID", sim.Value.ID);
                    cmd.Parameters.AddWithValue("@Name", sim.Value.Name);
                    cmd.Parameters.AddWithValue("@Birthday", sim.Value.Birthday);
                    cmd.ExecuteNonQuery(); // thực thi các lệnh SQL không trả về dữ liệu
                    Console.WriteLine("Thao tac insert thanh cong!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("NULL.Khong the thuc hien tac vu insert.");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

    }
}
