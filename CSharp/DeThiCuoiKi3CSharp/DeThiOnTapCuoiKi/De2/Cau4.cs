using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Câu 4 (3đ) Thiết kế UI (Chọn Controls, đặt Tab Order, chỉnh size và căn vị trí Control):  
Thiết kế form gồm 1 điều khiển listbox chọn bảng nhập Customer, hoặc Order gồm các điều 
khiển Label, 4 điều khiển edit, 1 button Nhập, 1 button Thoát (chương trình được đóng khi nhấn nút Thoát).  
Yêu cầu về UI (user interface) của form như sau:  
+ Đặt tiêu đề form tiếng Việt.  
+ Đặt tab order phù hợp cho các điều khiển.  
+ Đặt vị trí và kích thước phù hợp cho các điều khiển.  
+ Đặt forcus phù hợp khi form được load.   
Lập trình sự kiện khi nhấn nút Nhập:  
+ Bắt các giá trị nhập liệu ở các điều khiển Edit của form, kiểm tra tính Valid của các dữ liệu này 
(các trường khóa phải đủ 10 kí tự, không có giá trị text của điều khiển Edit nào là empty…) 
và nếu hợp lệ thì gọi các hàm NhapCustomer, NhapOrder để dữ liệu được nhập vào 
bảng Customer hoặc Order tùy thuộc người dùng chọn bảng.  
+ Khi form được Load thì bảng (được chọn) của CSDL được hiển thị trên DataGridView. 
 */

namespace De2
{
    internal class Cau4
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles(); // using System.Windows.Forms;
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Cau4_form());
        }
    }
}
