using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
/*
Câu 1 (1đ). Sử dụng một trong các hệ quản trị Cơ sở dữ liệu (CSDL) quan hệ SQL Server/MySQL, 
tạo 1 CSDL tên là “SimThe” để quản lý sim thẻ của 1 nhà mạng 
(nhập tay hoặc viết script hoặc viết lệnh C# với Entity), trong đó có 1 bảng Sim gồm: 
    SimID: kiểu xâu, độ dài cố định, lưu chuỗi 9 chữ số, là khóa chính. 
    SoSim: kiểu xâu, độ dài cố định, lưu chuỗi 10 chữ số, không là null (có thể đặt là khóa ngoài) 
    NgayKichHoat: kiểu ngày tháng hoặc để kiểu string 
    NgayHetHan: kiểu ngày tháng hoặc để kiểu string 
    GhiChu: kiểu string, độ dài thay đổi, lưu được tiếng Việt. 
 */

namespace De1_06082024
{
    internal class Cau1
    {
        static void Main(string[] args)
        {
            string txtSQLcreate = "CREATE TABLE Sim (SimID CHAR(9) PRIMARY KEY, SoSim CHAR(10) NOT NULL,NgayKichHoat DATE, NgayHetHan DATE, GhiChu NVARCHAR(MAX) );";
            thaoTac(txtSQLcreate);
        }
        static string strCon = "Data Source = HuongDuong ; Initial Catalog = SimThe ; Integrated Security = True";
        // Ham tao bang. Input : Cau lenh SQL 
        static void thaoTac(string txtSQLcreate)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            try
            {
                con.Open(); 
                SqlCommand cmd = new SqlCommand(txtSQLcreate, con);//lưu trữ câu lệnh SQL cần thực thi cùng với kết nối đến cơ sở dữ liệu.(data + @dich + tim duong)
                cmd.ExecuteNonQuery(); // thực thi các lệnh SQL không trả về dữ liệu
                Console.WriteLine("Create thanh cong!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Khong the thuc hien tac vu.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
