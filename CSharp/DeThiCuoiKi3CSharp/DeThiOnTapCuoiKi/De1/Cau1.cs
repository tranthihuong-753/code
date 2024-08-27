using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Câu 1 (1đ). Sử dụng một trong các hệ quản trị Cơ sở dữ liệu (CSDL) quan hệ SQL Server/MySQL, 
tạo 1 CSDL tên là “SimThe” để quản lý sim thẻ của 1 nhà mạng (nhập tay hoặc viết script hoặc viết lệnh C# với Entity), 
trong đó có 1 bảng Sim gồm: 
    SimID: kiểu xâu, độ dài cố định, lưu chuỗi 9 chữ số, là khóa chính. 
    SoSim: kiểu xâu, độ dài cố định, lưu chuỗi 10 chữ số, không là null (có thể đặt là khóa ngoài) 
    NgayKichHoat: kiểu ngày tháng hoặc để kiểu string 
    NgayHetHan: kiểu ngày tháng hoặc để kiểu string 
    GhiChu: kiểu string, độ dài thay đổi, lưu được tiếng Việt. 
 */

namespace De1
{
    internal class Cau1
    {
        // Cách 1 : Tạo trực tiếp trên SQL 
        string sql = "create table Sim (\r\n\tSimID varchar(9),\r\n\tSoSim varchar(10) not null,\r\n\tNgayKichHoat Datetime,\r\n\tNgayHetHan Datetime,\r\n\tGhiChu nvarchar(1000)\r\n);";
    }
}
