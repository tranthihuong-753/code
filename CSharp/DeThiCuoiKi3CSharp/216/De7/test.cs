//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Data;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace De7
//{
//    internal class test
//    {
//        ////3d.Viết hàm static xuất bảng Sim ra file định dạng csv. Gọi hàm ở Console hoặc GUI để kiểm tra. 

//        //static void SQLtoCSV(string nameFile)
//        //{
//        //    Dictionary<string, CongDan> cd = new Dictionary<string, CongDan>();
//        //    string columnName = "";
//        //    using (SqlConnection connection = new SqlConnection(strCon))
//        //    {
//        //        connection.Open();
//        //        string query = "SELECT * FROM CongDan";
//        //        using (SqlCommand command = new SqlCommand(query, connection))
//        //        {
//        //            using (SqlDataReader reader = command.ExecuteReader())
//        //            {
//        //                // Lay ten cot 
//        //                foreach (DataRow row in reader.GetSchemaTable().Rows)
//        //                {
//        //                    // Lấy tên cột từ DataRow
//        //                    columnName += " " + row["ColumnName"].ToString() + ",";
//        //                }
//        //                // Luu data tu bang SQL vao dic cd 
//        //                while (reader.Read())
//        //                {
//        //                    string ma;
//        //                    CongDan c = new CongDan(
//        //                        ma = reader["MaCD"].ToString(), // SQL string 
//        //                        reader["TenCD"].ToString(),
//        //                        reader["CCCD"].ToString(),
//        //                        reader["GioiTinh"].ToString(),
//        //                        Convert.ToDateTime(reader["NgaySinh"].ToString())
//        //                    );
//        //                    // Thêm đối tượng Sim vào danh sách
//        //                    cd.Add(ma, c);
//        //                }
//        //            }
//        //        }
//        //    }
//        //    if (cd == null)
//        //    {
//        //        Console.WriteLine("NULL");
//        //    }
//        //    FileStream st = new FileStream(nameFile, FileMode.Create, FileAccess.Write);
//        //    StreamWriter sw = new StreamWriter(st);
//        //    // them ten cot (la fong dau cua file csv) 
//        //    string tenCot = columnName.Substring(0, columnName.Length - 1);// xoa ki tu cuoi cung - la ky tu ','
//        //    sw.WriteLine(tenCot);
//        //    foreach (CongDan c in cd.Values)
//        //    {
//        //        sw.WriteLine($"{c.MaCD}, {c.TenCD}, {c.CCCD}, {c.GioiTinh}, {c.NgaySinh}");
//        //        Console.WriteLine(($"{c.MaCD}, {c.TenCD}, {c.CCCD}, {c.GioiTinh}, {c.NgaySinh}"));
//        //    }
//        //    Console.WriteLine("Ghi vao file CSV thanh congg.");
//        //    sw.Close();
//        //}
//        //static void run_3d_SQLtoCSV()
//        //{
//        //    string file = "D:\\CODE_Study_CMC\\CSharp\\DeThiCuoiKi3CSharp\\De7\\congdan.csv";
//        //    SQLtoCSV(file);
//        //}

//        // Hàm khi di chuột thì hiện lên textbox1 <3>
//        private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
//            {
//                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
//                textBox1.Text = cellValue != null && cellValue != DBNull.Value ? cellValue.ToString() : string.Empty;
//            }
//            else
//            {
//                textBox1.Text = string.Empty;
//            }
//        }
//    }
//}
