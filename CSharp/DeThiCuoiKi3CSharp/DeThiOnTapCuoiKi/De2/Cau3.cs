using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static De2.Cau2;

/*
- Viết 1 hàm static nhập vào số nguyên dương n trong khoảng từ 2 đến 10. Nếu nhập sai thì nhập lại.
Gọi hàm trong lớp chứa hàm Main() để kiểm tra. 
- Viết hàm static xuất bảng Customers ra file JSON. Gọi hàm trong hàm Main() để kiểm tra. 
 */

namespace De2
{
    internal class Cau3
    {
        static void Main(string[] args)
        {
            input_n();
        }
        // Ham nhập vào số nguyên dương n trong khoảng từ 2 đến 10
        static int input_n()
        {
            int n; 
            while (true)
            {
                try
                {
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    if(n >= 2 && n <= 10)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nhap vao so nguyen tu 2 den 10.");
                    }

                }catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return n;
        }
        //hàm static xuất bảng Customers ra file JSON
        static void SQLtoJSON(string nameFile)
        {
            List<Customer> data = new List<Customer>(); // using static De2.Cau2;
            string strCon = "Data Source = HuongDuong ; Initial Catalog = SimThe ; Integrated Security = True";
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open(); // Mở kết nối
                string query = "SELECT * FROM Customers"; // Câu lệnh SQL để truy vấn dữ liệu từ bảng Sim
                // Tạo SqlCommand để thực hiện truy vấn
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thực hiện truy vấn và lấy dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Đọc từng dòng dữ liệu từ SqlDataReader
                        while (reader.Read())
                        {
                            // Tạo đối tượng Sim từ dữ liệu đọc được
                            Customer c = new Customer(
                                reader["CustomerID"].ToString(),
                                reader["Name"].ToString(),
                                reader["Address"].ToString(),
                                reader["Email"].ToString()
                            );
                            // Thêm đối tượng Sim vào danh sách
                            data.Add(c);
                        }
                    }
                }
            }
            //foreach (var x in data)
            //{
            //    Console.WriteLine(x.CustomerID + " " + x.Name + " " + x.Address + " " + x.Email );
            //}
            // Chuyển đổi dictionary thành định dạng JSON
            string json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented); // Tải Newtonsoft.Json 
            Console.WriteLine("json = " + json);
            try
            {
                File.WriteAllText(nameFile, json);
                Console.WriteLine("Dữ liệu đã được lưu vào file JSON thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lưu dữ liệu vào file: {ex.Message}");
            }
        }
    }
}
