using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static De2.Cau2;

namespace De2
{
    public partial class Cau4_form : Form
    {
        public Cau4_form()
        {
            InitializeComponent();
            // Đặt tiêu đề form <1>
            this.Text = "Bán Hàng rong";

        }
        // Hàm load dữ liệu từ SQL Sales cho vào datagridview <2>
        private void LoadData(string nametable)
        {
            string myLap3 = "Data Source=HuongDuong;Initial Catalog=Sales;Integrated Security=True";
            string txtSql = $"SELECT * FROM {nametable}";
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
        // Lay ten cot cua cac bang trong SQL dua vao cac text <3>
        static string strCon = "Data Source = HuongDuong ; Initial Catalog = Sales ; Integrated Security = True";
        private void namerow_SQLtoLabel(string nametable)
        {
            string[] arr = new string[4];
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                string query = $"SELECT * FROM {nametable}";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int i = 0;
                        // Lay ten cot 
                        foreach (DataRow row in reader.GetSchemaTable().Rows)
                        {
                            // Lấy tên cột từ DataRow
                            arr[i] = row["ColumnName"].ToString();i++;
                        }
                    }
                }
            }
            // dua vao label 
            label3.Text = arr[0];
            label4.Text = arr[1];
            label5.Text = arr[2];
            label6.Text = arr[3];
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chuyen checkonclick -> true de cho phep nhan su kien click <2>
            // Hiển thị table tương ứng trong DataGridView
            string selectedItem = checkedListBox1.SelectedItem?.ToString();
            if (selectedItem == "Customer")
            {
                LoadData("Customers");
                label2.Text = "Table Customers";
                // Lay ten cot cua cac bang trong SQL dua vao cac text <3>
                namerow_SQLtoLabel("Customers");
            }
            else if (selectedItem == "Order")
            {
                LoadData("Orders");
                label2.Text = "Table Orders";
                // Lay ten cot cua cac bang trong SQL dua vao cac text <3>
                namerow_SQLtoLabel("Orders");
            }
        }
        // Thoat chuong trinh 
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // Nhap vao 4 gia tri roi them vao SQL 
        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = cot1.Text; // <5>
            string s2 = cot2.Text;
            string s3 = cot3.Text;
            string s4 = cot4.Text;

            string selectedItem = checkedListBox1.SelectedItem?.ToString(); // <5>
            if (selectedItem == "Customer")
            {
                // Kiem tra 
                int check = 1; // them ban ghi vao SQL duoc 
                // CustomerID: kiểu xâu, độ dài cố định, lưu chuỗi 10 chữ số, là khóa chính  
                try
                {
                    int.Parse(s1);
                    if (s1.Length != 10)
                    {
                        //Console.WriteLine("Nhap vao chuoi 10 chu so.");
                        MessageBox.Show("Nhap vao chuoi 10 chu so.");
                        check = 0;
                    }
                }
                catch (Exception ez)
                {
                    MessageBox.Show("Nhap vao chuoi 10 chu so. \n" + ez.ToString());
                    check = 0;
                }
                if(check == 1)
                {
                    List<Customer> list = new List<Customer>();
                    list.Add(new Customer(s1, s2, s3, s4));
                    try
                    {
                        NhapCustomer(list);
                        MessageBox.Show("INSERT thành công.");
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }
            else if (selectedItem == "Order")
            {
                int check = 1; // them ban ghi vao SQL duoc 
                //OrderID: kiểu xâu, độ dài cố định, lưu chuỗi 10 chữ số, là khóa chính
                try
                {
                    int.Parse(s1);
                    if (s1.Length != 10)
                    {
                        MessageBox.Show("Nhap vao id la chuoi 10 chu so .");
                        check = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhap vao id la chuoi 10 chu so .\n" + ex.ToString());
                    check = 0;
                }
                //Product: kiểu string, độ dài thay đổi tối đa 50 kí tự
                if (s2.Length > 50)
                {
                    MessageBox.Show("Nhap vao product co toi da 50 ki tu.");
                    check = 0;
                }
                //Quantity: kiểu số nguyên
                int ss3 = -1;
                try
                {
                    int.TryParse(s3, out ss3);
                    if (ss3 < 0)
                    {
                        MessageBox.Show("Nhap so nguyen.");
                        check = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //CustomerID: kiểu số nguyên là khóa ngoài của Customers(CustomerID)
                // CustomerID: kiểu xâu, độ dài cố định, lưu chuỗi 10 chữ số, là khóa chính  
                try
                {
                    int.Parse(s4);
                    if (s4.Length != 10)
                    {
                        MessageBox.Show("Nhap vao chuoi 10 chu so.");
                        check = 0;
                    }
                }
                catch (Exception ez)
                {
                    MessageBox.Show("Nhap vao chuoi 10 chu so. \n" + ez.Message);
                    check = 0;
                }
                if (check == 1)
                {
                    List<Order> list = new List<Order>();
                    list.Add(new Order(s1, s2, ss3, s4));
                    try
                    {
                        NhapOrder(list);
                        MessageBox.Show("INSERT thành công.");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("ss "+ ex.Message);
                    }
                }
            }
        }
    }
}
