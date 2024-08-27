using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
// Tải newtonsoft 

/*
Câu 3 (4đ). Khai báo 1 class Sim gồm các biến public: simID, soSim, ngayKichHoat, ngayHetHan 
và ghiChu với kiểu dữ liệu phù hợp trong 1 file .cs riêng. <Làm ở câu 1>
    - 3a. Viết hàm static nhập vào từ bàn phím không quá n đối tượng Sim vào 1 biến kiểu dữ liệu Dictionary với khóa là simID. 
Khi nhập có xử lý Exception, nếu nhập simID là “#” thì kết thúc nhập. 
Hàm trả lại giá trị biến kiểu Dictionary lưu các giá trị được nhập. 
Gọi hàm trong hàm Main() để lấy n đối tượng Sim lưu vào biến dict1.  
    - 3b. Viết câu lệnh duyệt dict1 để chỉ hiển thị các sim có ngày kích hoạt là 14/08/2023. 
    - 3c. Viết hàm static GhiBangSim, hàm kết nối với CSDL SimThe, ghi dict1 vào bảng Sim, 
khi ghi không thành công hàm trả lại giá trị null. Gọi hàm trong hàm Main() để kiểm tra. 
    - 3d. Đặt hàm GhiBangSim vào thực hiện trong 1 thread. Kích hoạt thread trong hàm Main(). 
Khi thread đã hoàn thành thì hiện thông báo đã thực hiện xong.
 */

namespace De1_06082024
{
    internal class Cau3
    {
        static void Main(string[] args)
        {
            // 3a
            Dictionary<string, Sim> dict1 = InputSims(2);
            // 3b 
            //Cau2b(new DateTime(2023, 08, 14), dict1); 
            // 3c
            run_3c_GhiBangSim(dict1);
            //run_3d();
            //run_SQLtoJSON();
        }
        // 3a. Hàm nhập dữ liệu và trả về Dictionary
        static Dictionary<string, Sim> InputSims(int n)
        {
            Dictionary<string, Sim> simd = new Dictionary<string, Sim>();
            int count = 1; // biến đếm bản ghi 
            // Mảng chứa các màu tùy chọn
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Random random = new Random();
            while (count <= n)
            {
                Console.ForegroundColor = colors[random.Next(colors.Length)];
                Console.WriteLine($"BẢN GHI {count}");
                // Nhập simID lưu chuỗi 9 chữ số, simID not in Dictionary 
                string simID;
                while (true)
                {
                    // Nhập simID lưu chuỗi 9 chữ số
                    Console.Write("SimID (nhập '#' để kết thúc): ");
                    simID = Console.ReadLine();
                    if (simID == "#")
                    {
                        return null; // Kết thúc khi người dùng nhập '#'
                    }
                    if (simd.ContainsKey(simID)) // kiểm tra xem key simID có tồn tại trong Dictionary simd chua 
                    { 
                        Console.WriteLine("SimID đã tồn tại.");
                        continue;
                    }
                    if (int.TryParse(simID, out int number))
                    {
                        if (simID.Length == 9)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lỗi! Độ dài simID = 9.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lỗi! Nhập vào chuỗi số có length = 9.");
                    }
                }
                //if (simID == "#")
                //{
                //    break; // Kết thúc khi người dùng nhập '#'
                //}
                // Nhập SoSim 10 chữ số 
                string soSim;
                while (true)
                {
                    // Nhập simID lưu chuỗi 9 chữ số
                    Console.Write("SoSim: ");
                    soSim = Console.ReadLine();
                    if (simd.ContainsKey(soSim)) // kiểm tra xem key simID có tồn tại trong Dictionary simd chua 
                    {
                        Console.WriteLine("SoSim đã tồn tại.");
                        continue;
                    }
                    if (int.TryParse(soSim, out int number))
                    {
                        if (soSim.Length == 10)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lỗi! Độ dài SoSim = 10.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lỗi! Nhập vào chuỗi số có length = 10.");
                    }
                }

                // Ngày kích hoạt 
                Console.Write("NgayKichHoat (yyyy-MM-dd): ");
                DateTime ngayKichHoat;
                if (!DateTime.TryParse(Console.ReadLine(), out ngayKichHoat))
                {
                    Console.WriteLine("Ngày kích hoạt không hợp lệ.");
                    continue;
                }

                // Ngày hết hạn 
                DateTime ngayHetHan;
                while (true) 
                {
                    Console.Write("NgayHetHan (yyyy-MM-dd): ");
                    if (!DateTime.TryParse(Console.ReadLine(), out ngayHetHan))
                    {
                        Console.WriteLine("Ngày hết hạn không hợp lệ.");
                        continue;
                    }
                    // Kiểm tra ngày hết hạn phải lớn hơn ngày kích hoạt
                    if (ngayHetHan <= ngayKichHoat)
                    {
                        Console.WriteLine("Ngày hết hạn phải lớn hơn ngày kích hoạt.");
                        continue;
                    }
                    break;// Nếu tất cả các kiểm tra đều hợp lệ, thoát khỏi vòng lặp
                }
            
                // Ghi chú 
                Console.Write("GhiChu: ");
                string ghiChu = Console.ReadLine();

                // Tạo đối tượng Sim và thêm vào Dictionary
                Sim sim = new Sim(simID, soSim, ngayKichHoat, ngayHetHan, ghiChu);
                simd[simID] = sim;
                count++;
            }
            return simd;
        }

        // 3b. Viết câu lệnh duyệt dict1 để chỉ hiển thị các sim có ngày kích hoạt là 14/08/2023. 
        static void Cau2b(DateTime time, Dictionary<string, Sim> d)
        {
            Console.WriteLine("Các sim có ngày kích hoạt là 14/08/2023:");
            foreach (var kvp in d)
            {
                Sim sim = kvp.Value;
                if (sim.ngayKichHoat.Date == time.Date)
                {
                    Console.WriteLine($"SimID: {sim.simID}, SoSim: {sim.soSim}, NgayKichHoat: {sim.ngayKichHoat.ToShortDateString()}, NgayHetHan: {sim.ngayHetHan.ToShortDateString()}, GhiChu: {sim.ghiChu}");
                }
            }
        }
        // 3c. Viết hàm static GhiBangSim, hàm kết nối với CSDL SimThe,
        // ghi dict1 vào bảng Sim, khi ghi không thành công hàm trả lại giá trị null.
        // Gọi hàm trong hàm Main() để kiểm tra.
        static string strCon = "Data Source = HuongDuong ; Initial Catalog = SimThe ; Integrated Security = True";
        static void GhiBangSim(Dictionary<string, Sim> dict1)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            //string txtSQLcreate = "INSERT INTO Sim(SimID, SoSim, NgayKichHoat, NgayHetHan, GhiChu) VALUES(@SimID, @SoSim, @NgayKichHoat, @NgayHetHan, @GhiChu)";
            foreach (Sim sim in dict1.Values)
            {
                try
                {
                    con.Open();
                    string txtSQLcreate = "INSERT INTO Sim(SimID, SoSim, NgayKichHoat, NgayHetHan, GhiChu) VALUES (@SimID, @SoSim, @NgayKichHoat, @NgayHetHan, @GhiChu);"; // Neu dung $ them thang value vao thi loi -> So khong du bao mat -> Dung @ 
                    SqlCommand cmd = new SqlCommand(txtSQLcreate, con);//lưu trữ câu lệnh SQL cần thực thi cùng với kết nối đến cơ sở dữ liệu.(data + @dich + tim duong)
                    cmd.Parameters.AddWithValue("@SimID", sim.simID);
                    cmd.Parameters.AddWithValue("@SoSim", sim.soSim);
                    cmd.Parameters.AddWithValue("@NgayKichHoat", sim.ngayKichHoat);
                    cmd.Parameters.AddWithValue("@NgayHetHan", sim.ngayHetHan);
                    cmd.Parameters.AddWithValue("@GhiChu", sim.ghiChu);
                    cmd.ExecuteNonQuery(); // thực thi các lệnh SQL không trả về dữ liệu
                    Console.WriteLine("Thao tac insert thanh cong!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Khong the thuc hien tac vu insert.");
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }
        static void run_3c_GhiBangSim(Dictionary<string, Sim> dict1)
        {
            //Dictionary<string, Sim> dict1 = InputSims(2);
            GhiBangSim(dict1);
        }
        //3d_De 1 Đặt hàm GhiBangSim vào thực hiện trong 1 thread.
        //Kích hoạt thread trong hàm Main().
        //Khi thread đã hoàn thành thì hiện thông báo đã thực hiện xong.
        static void run_3d()
        {
            Dictionary<string, Sim> dict1 = InputSims(2);
            Thread thread = new Thread(() => GhiBangSim(dict1));// Tạo và khởi động luồng để thực hiện hàm GhiBangSim
            thread.Start();
            thread.Join();// Đợi cho luồng hoàn tất
            Console.WriteLine("Thread thực hiện xong.");// Thông báo khi hoàn tất
        }
        //3d_De 2 Viết hàm static xuất bảng SoSIM ra file JSON. 
        static void SQLtoJSON(string nameFile)
        {
            List<Sim> data = new List<Sim>();
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                // Mở kết nối
                connection.Open();
                // Câu lệnh SQL để truy vấn dữ liệu từ bảng Sim
                string query = "SELECT SimID, SoSim, NgayKichHoat, NgayHetHan, GhiChu FROM Sim";

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
                            Sim sim = new Sim(
                                reader["SimID"].ToString(),
                                reader["SoSim"].ToString(),
                                Convert.ToDateTime(reader["NgayKichHoat"]),
                                Convert.ToDateTime(reader["NgayHetHan"]),
                                reader["GhiChu"].ToString()
                            );
                            // Thêm đối tượng Sim vào danh sách
                            data.Add(sim);
                        }
                    }
                }
            }
            foreach (var x in data)
            {
                Console.WriteLine(x.simID + " " + x.ghiChu + " " + x.ngayKichHoat + " " + x.ngayKichHoat + " " + x.soSim);
            }
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
        static void run_SQLtoJSON()
        {
            string nameFile = "D:\\LinhTinhVoVanXamChoa\\CSharp\\DeThiCK\\De1_06082024\\Sim_De2_3d.json";
            SQLtoJSON(nameFile);
        }
    }
}
