using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Câu 1 (1đ). Sử dụng một trong các hệ quản trị Cơ sở dữ liệu (CSDL) quan hệ SQL Server/MySQL, 
tạo 1 CSDL tên là “Hanghoa” để quản lý Hàng hóa của 1 của hàng 
(nhập tay hoặc viết script hoặc viết lệnh C# với Entity), 
trong đó có 1 bảng tblHanghoa gồm: 
    ID: String, độ dài cố định, lưu chuỗi 5 chữ số, là khóa chính. 
    MaVach: String, độ dài cố định, lưu chuỗi 13 chữ số, không là null (có thể đặt là khóa ngoài). 
    Ten: String (200), GiaNhap: Float, GiaBan: Float, GhiChu: String 
Các trường String có thể lưu dữ liệu unicode Tiếng Việt. 
 */
namespace De3
{
    internal class Cau1
    {
        // Tạo bảng bằng SQL ngay trên SQLServer
        string createtable = "CREATE TABLE tblHanghoa (\r\n    ID CHAR(5) PRIMARY KEY,\r\n    MaVach CHAR(13) NOT NULL,\r\n    Ten VARCHAR(200),\r\n    GiaNhap FLOAT,\r\n    GiaBan FLOAT,\r\n    GhiChu VARCHAR(255)\r\n);\r\n";
    }
}
