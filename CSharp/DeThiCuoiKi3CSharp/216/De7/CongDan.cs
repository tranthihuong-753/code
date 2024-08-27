using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace De7
{
    internal class CongDan
    {
        //--    MaCD: String, độ dài cố định, lưu chuỗi 9 chữ số, là khóa chính; 
        //--    TenCD: String(độ dài không quá 200), có thể lưu dữ liệu unicode Tiếng Việt; 
        //--    CCCD: String, độ dài cố định, lưu chuỗi 12 chữ số(có thể đặt là khóa ngoài); 
        //--    GioiTinh: String, lưu được 3 giá trị “Nam/Nữ/Không xác định; 
        //--    NgaySinh: String, hoặc kiểu date.
        public string MaCD;
        public string TenCD;
        public string CCCD;
        public string GioiTinh;
        public DateTime NgaySinh;
        public CongDan(string a, string b, string c, string d, DateTime e)
        {
            MaCD = a;TenCD = b;CCCD = c;GioiTinh = d;NgaySinh = e;
        }
    }
}
