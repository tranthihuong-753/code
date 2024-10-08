﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace De1_06082024
{
    public partial class Cau4_Form_1 : Form
    {
        public Cau4_Form_1()
        {
            InitializeComponent();
            // Đặt tiêu đề form 
            this.Text = "Quản Lý Số SIM";
            // Load dữ liệu từ SQL cho vào datagridview 
            LoadData();
            // Đăng ký sự kiện di chuột cho DataGridView
            dataGridView1.CellMouseEnter += DataGridView1_CellMouseEnter;
            // Hàm Enter = button2_Click (nhán nút enter)
            textBox1.KeyDown += new KeyEventHandler(textBox1_KeyDown);
        }
        // Hàm load dữ liệu từ SQL cho vào datagridview 
        private void LoadData()
        {
            string myLap3 = "Data Source=HuongDuong;Initial Catalog=SimThe;Integrated Security=True";
            string txtSql = "SELECT * FROM Sim";
            SqlConnection con = new SqlConnection(myLap3);

            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand(txtSql, con);
                SqlDataReader sdr = cm.ExecuteReader();

                // Xóa tất cả các cột và hàng hiện có (nếu có)
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                // Lấy thông tin về các cột
                var columnNames = new List<string>();
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    columnNames.Add(sdr.GetName(i));
                    dataGridView1.Columns.Add(sdr.GetName(i), sdr.GetName(i)); // Thêm cột vào DataGridView
                }

                // Đọc và thêm từng dòng dữ liệu vào DataGridView
                while (sdr.Read())
                {
                    var rowValues = new List<object>();
                    foreach (var columnName in columnNames)
                    {
                        rowValues.Add(sdr[columnName]);
                    }
                    dataGridView1.Rows.Add(rowValues.ToArray()); // Thêm hàng vào DataGridView
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        // Hàm khi di chuột thì hiện lên textbox1 
        // check_cons 
        private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            check_cons = false;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                textBox1.Text = cellValue != null && cellValue != DBNull.Value ? cellValue.ToString() : string.Empty;
                //check_cons = false;
            }
            else
            {
                textBox1.Text = string.Empty;
            }
            check_cons = true;
        }
        // Hàm có tác dụng kiểm tra xem length.textbox=10 -> thực hiện
        private void search()
        {
            string txttextbox1 = textBox1.Text.Trim(); // Lấy giá trị từ textBox1 và loại bỏ khoảng trắng
            int hangDataGridView = dataGridView1.Rows.Count; // Lấy số lượng hàng trong DataGridView (bao gồm cả hàng tiêu đề)
            if (txttextbox1.Length == 10)
            {
                bool found = false; // Biến cờ để xác nhận nếu tìm thấy hàng hợp lệ
                // Ẩn tất cả các hàng trong DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow) // Chỉ ẩn các hàng đã cam kết
                    {
                        row.Visible = false;
                    }
                }
                // Lặp qua tất cả các hàng để tìm hàng có giá trị tương ứng
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Kiểm tra nếu giá trị của cột thứ 2 (sosim) bằng giá trị nhập vào
                    if (!row.IsNewRow && row.Cells[1].Value != null && row.Cells[1].Value.ToString() == txttextbox1)
                    {
                        // Hiển thị hàng đó và đặt cờ found = true
                        row.Visible = true;
                        found = true;
                        MessageBox.Show("Tim thay.");
                        break; // Dừng vòng lặp sau khi tìm thấy hàng
                    }
                }

                // Nếu không tìm thấy hàng, hiển thị thông báo lỗi
                if (!found)
                {
                    MessageBox.Show("Không tìm thấy.");
                    LoadData(); // Trả lại datagridview ban đầu 
                }
            }
            else
            {
                // Nếu độ dài của giá trị nhập vào không bằng 10, hiển thị thông báo lỗi
                MessageBox.Show("Giá trị nhập vào phải có độ dài là 10 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus(); // trỏ con trỏ tới textbox1 
            }
            // Cập nhật DataGridView sau khi thực hiện thay đổi
            dataGridView1.Refresh();
        }
        // Hàm Enter = button2_Click (nhán nút enter)
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím nhấn là phím Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Ngăn chặn việc nhấn Enter tạo một dòng mới trong TextBox (nếu là multi-line)
                e.SuppressKeyPress = true;

                // Gọi sự kiện Click của button2
                button2.PerformClick();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            search();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Không cho textbox nhập ký tự khác int 
        private Boolean check_cons = true; // có 2 sự kiện với textbox1 -> Xung đột với nhau -> check_cons = true là nhập từ bàn phím 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị hiện tại của TextBox trực tiếp từ biến textBox1
            string txtbox = textBox1.Text;
            // Kiểm tra xem có ký tự không phải số không
            string txtedit = "";
            foreach (char c in txtbox)
            {
                if (char.IsDigit(c))
                {
                    txtedit += c; // Thêm ký tự số vào filteredText
                }
                else
                {
                    textBox1.Text = txtedit;
                    // Đặt con trỏ về cuối TextBox để người dùng tiếp tục nhập
                    textBox1.SelectionStart = txtedit.Length; // textBox3.SelectionStart = textBox3.Text.Length;
                    Console.WriteLine("beep");
                    SystemSounds.Beep.Play();
                }
            }
            //this.Refresh();
        }
        private void txtID_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
