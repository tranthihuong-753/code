using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Câu 1 (2đ). Tạo CSDL:  
Sử dụng một trong các hệ quản trị Cơ sở dữ liệu (CSDL) SQL (SQL Server, MySQL) tạo 1 CSDL tên là “Sales” 
(nhập tay hoặc viết script hoặc viết lệnh C# với Entity), 
trong đó có 02 bảng:  
Bảng Customers  
    CustomerID: kiểu xâu, độ dài cố định, lưu chuỗi 10 chữ số, là khóa chính  
    Name: kiểu string, độ dài thay đổi, lưu được tiếng Việt 
    Address: kiểu string, độ dài thay đổi, lưu được tiếng Việt 
    Email: kiểu string, độ dài thay đổi. 
Bảng Orders  
    OrderID: kiểu xâu, độ dài cố định, lưu chuỗi 10 chữ số, là khóa chính 
    Product: kiểu string, độ dài thay đổi tối đa 50 kí tự  
    Quantity: kiểu số nguyên   
    CustomerID: kiểu số nguyên là khóa ngoài của Customers(CustomerID)  
Sau đó nhập mỗi bảng khoảng từ 3 đến 6 bản ghi minh họa. 
 */

namespace De2
{
    internal class Cau1
    {
        string createtl1 = "create table Customers (CustomerID varchar(10) primary key, Name varchar(100), Address varchar(200), Email varchar(200));";
        string createtl2 = "create table Orders ( OrderID varchar(10), Product varchar(50), Quantity int, CustomerID int, FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID));";
    }
}
