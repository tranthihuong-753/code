using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1_06082024
{
    internal class Cau4
    {
        //AutoSizeColum -> Fill -> Các cột sẽ tự động điều chỉnh để lấp đầy chiều rộng của DataGridView
        //Anchor -> Khi run form , các thành phần cũng thay đổi thao kích cớ form 
        static void Main(string[] args)
        {
            Application.EnableVisualStyles(); // using System.Windows.Forms;
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Form1 form1 = new Form1();
            //Form2 form2 = new Form2();
            //// Hiển thị cả hai form
            //form1.Show();
            //form2.Show();
            //// Đảm bảo ứng dụng không kết thúc ngay lập tức
            //Application.Run(); // Chạy ứng dụng mà không truyền form chính
            Application.Run(new Cau4_Form_1());
            //Application.Run(new Form2()); // Chỉ khởi chạy Form2
        }
    }
}
