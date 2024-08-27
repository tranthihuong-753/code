using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Câu 4 (3đ) 
4a. Thiết kế UI (Chọn Controls, đặt Tab Order, chỉnh size và căn vị trí Controls): 
Thiết kế form gồm 1 điều khiển gồm các điều khiển Label, 1 điều khiển edit mã vạch (txtmavach), 
1 button Tìm kiếm (cmdtim), 1 button Thoát(cmdthoat) (chương trình được đóng khi nhấn nút Thoát), 
1 DataGridView control để hiển thị bảng tblHanghoa. 
Yêu cầu về UI (user interface) của form như sau: 
4b. Lập trình xử lý các sự kiện: 
+ Khi form được Load thì bảng tblHanghoa được hiển thị trên DataGridView. 
+ Khi click chuột trên DataGridView, txtmavach được hiển thị dữ liệu tương ứng từ DataGridView. 
+ Khi nhập dữ liệu ở txtmavach chỉ cho phép nhập chữ số. 
4c. Khi nhập dữ liệu ở txtmavach nhấn phím Enter hoặc nhấn chuột ở nút Tìm kiếm thì: 
+ Nếu độ dài text ở txtmavach là 13 thì duyệt DataGridView để tìm kiếm Mavach của dòng của 
DataGridView trùng với nội dung textbox txtmavach. Nếu tìm thấy thì dịch chuyển dòng hiện 
thời của DataGridView tới vị trí được tìm thấy và hiển thị hộp thoại với thông báo “Tìm thấy số 
hàng hóa…”. Ngược lại, thông báo không tìm thấy. Sau đó lại focus về điều khiển nhập txtmavach. 
+ Nếu độ dài ở txtmavach là khác 13 thì hiển thị hộp thoại với thông báo “mã vạch không hợp lệ”. 
Sau đó lại focus về điều khiển nhập txtmavach.
 */

namespace De3
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
