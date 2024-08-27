using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Câu 3 (3đ).  
Khai báo 1 class CHanhoa gồm các biến public: id, mavach, ten, gianhap,giaban,ghichu dữ liệu 
phù hợp trong 1 file .cs riêng. 

3a. Viết hàm static nhập vào từ bàn phím không quá n đối tượng Hàng hóa 
vào 1 biến kiểu dữ liệu List với khóa là id. 
Khi nhập có xử lý Exception, nếu nhập id là “#” thì kết thúc nhập. 
Hàm trả lại giá trị biến kiểu List lưu các giá trị được nhập. 
Gọi hàm trong hàm Main() để lấy n đối tượng Hàng hóa lưu vào biến hanghoa1. 

3b. Viết câu lệnh duyệt hanghoa1 để chỉ hiển thị các hàng hóa có giá nhập >= 100000. 

3c. Viết hàm static LuuDB, hàm kết nối với CSDL Hanghoa, ghi hanghoa1 vào bảng tblHanghoa, 
khi ghi không thành công hàm trả lại giá trị null. Gọi hàm trong hàm Main() để kiểm tra. 

3d_DE3. Viết hàm static xuất bảng hanghoa ra file JSON. Gọi hàm trong hàm Main() để kiểm tra. 

3d_DE4. Viết hàm static xuất bảng hanghoa ra file CSV. Gọi hàm trong hàm Main() để kiểm tra.

3d_DE5. Đặt hàm LuuDB vào thực hiện trong 1 thread. Kích hoạt thread trong hàm Main(). Khi thread 
đã hoàn thành thì hiện thông báo đã thực hiện xong.

3d_DE6. Viết thêm 1 hàm static cũng tên là LuuDB (cùng tính năng với hàm static LuuDB ở câu 3c) 
dưới dạng 1 Task để gọi trong chế độ không đồng bộ async/await. 
Chuyển hàm Main() thành 1 Task để gọi Task LuuDB. 
Khi thực hiện xong hàm Task LuuDB, thông báo "Task đã thực hiện xong". 
 */

namespace De3
{
    internal class Cau3
    {
        static void Main(string[] args)
        {
            //run_3a_inputListHanghoa();
            //run_3b_gianhaplon();
            //run_3c_LuuDB();
            //run_3d_DE3_SQLtoJSON();
            //run_3d_DE4_SQLtoCSV();
            run_3d_DE5();
        }

        // 3a
        class hanghoa
        {
            //ID: String, độ dài cố định, lưu chuỗi 5 chữ số, là khóa chính. 
            // MaVach: String, độ dài cố định, lưu chuỗi 13 chữ số, không là null (có thể đặt là khóa ngoài). 
            // Ten: String(200)
            // GiaNhap: Float
            // GiaBan: Float
            // GhiChu: String
            public string ID { get; set; }
            public string MaVach { get; set; }
            public string Ten { get; set; }
            public float GiaNhap { get; set; }
            public float GiaBan { get; set; }
            public string GhiChu { get; set; }
            public hanghoa(string a, string b, string c, float d, float e, string f)
            {
                ID = a; MaVach = b; Ten = c; GiaNhap = d; GiaBan = e; GhiChu = f;
            }
        }
        static List<hanghoa> inputListHanghoa(int m)
        {
            List<hanghoa> l = new List<hanghoa>();
            int n = 0;
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Random random = new Random();
            while (n != m)
            {
                Console.ForegroundColor = colors[random.Next(colors.Length)];
                Console.WriteLine($"NHAP VAO BAN GHI HANG HOA {n + 1}. ");
                //ID: String, độ dài cố định, lưu chuỗi 5 chữ số, là khóa chính. # thi ket thuc nhap 
                string id;
                while (true)
                {
                    Console.Write("ID: ");
                    id = Console.ReadLine();
                    // Nhap #
                    if (id == "#")
                    {
                        return l ;
                    }
                    // Khoa chinh 
                    int i = 0; // ID khong ton tai trong list 
                    foreach (hanghoa meo in l)
                    {
                        if (id == meo.ID)
                        {
                            Console.WriteLine("ID da ton tai trong list.");
                            i = 1;
                        }
                    }
                    if(i != 0)
                    {
                        continue;
                    }
                    // 5 chu so
                    try
                    {
                        int.Parse(id);
                        if (id.Length == 5)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nhap vao chuoi 5 chu so.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Nhap vao chuoi 5 chu so. \n" + e.Message);
                    }
                }
                // MaVach: String, độ dài cố định, lưu chuỗi 13 chữ số, không là null (có thể đặt là khóa ngoài). 
                string mavach;
                while (true)
                {
                    Console.Write("Ma Vach : ");
                    mavach = Console.ReadLine();
                    // Khoa ngoai, khong duoc lap lai 
                    int i = 0; // khong co trong list 
                    foreach (hanghoa meo in l)
                    {
                        if (mavach == meo.MaVach)
                        {
                            Console.WriteLine("Ma Vach da ton tai.");
                            i = 1;
                        }
                    }
                    if(i != 0)
                    {
                        continue;
                    }
                    try
                    {
                        double.Parse(mavach);
                        if(mavach.Length == 13)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ma vach la chuoi 13 chu so.");
                        }
                    }catch(Exception e) 
                    { 
                        Console.WriteLine("Ma vach la chuoi 13 chu so.\n" + e.Message); 
                    }
                }
                // Ten: String(200)
                Console.Write("Name: ");
                string ten = Console.ReadLine();
                // GiaNhap: Float
                string gnexp;
                float gn;
                while (true)
                {
                    Console.Write("Gia nhap : ");
                    gnexp = Console.ReadLine();
                    try
                    {
                        gn = float.Parse(gnexp);
                        if(gn >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Gia nha khong the am.");
                        }
                    }catch(Exception e)
                    {
                        Console.WriteLine("Gia nhap o dang float.\n" + e.Message);
                    }
                }
                // GiaBan: Float
                string gbexp;
                float gb;
                while (true)
                {
                    Console.Write("Gia ban : ");
                    gbexp = Console.ReadLine();
                    try
                    {
                        gb = float.Parse(gbexp);
                        if (gb >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Gia ban khong the am.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Gia ban o dang float.\n" + e.Message);
                    }
                }
                // GhiChu: String
                Console.Write("Ghi chu : ");
                string ghichu = Console.ReadLine();
                // Them vao list 
                hanghoa hh = new hanghoa(id, mavach, ten, gn, gb, ghichu);
                try
                {
                    l.Add(hh);
                    n++;
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return l;
        }
        static void run_3a_inputListHanghoa()
        {
            List<hanghoa> l = inputListHanghoa(2);
            // in ra man hinh 
            Console.WriteLine("In ra id :");
            foreach(hanghoa h in l)
            {
                Console.WriteLine("     " + h.ID);
            }
        }

        //3b 
        // Ham tra ve list hang hoa co gia nhap >= 100000
        static List<hanghoa> gianhaplon(List<hanghoa> l)
        {
            List<hanghoa> lout = new List<hanghoa>();
            foreach (hanghoa h in l)
            {
                if(h.GiaNhap >= 100000)
                {
                    lout.Add(h);
                }
            }
            return lout;
        }
        static void run_3b_gianhaplon()
        {
            List<hanghoa> l = gianhaplon(inputListHanghoa(3));
            Boolean check = false; // khong co hang hoa >= 100000
            Console.WriteLine("Hang hoa co gia nhap >= 100000 la : ");
            // in ra
            foreach (hanghoa h in l)
            {
                if(h.GiaNhap >= 100000)
                {
                    Console.WriteLine("  " + h.ID + " gia nhap " + h.GiaNhap);
                    check = true;
                }
            }
            if(check == false)
            {
                Console.WriteLine("Khong co hang hoa nao co gia nhap >= 100000.");
            }
        }

        //3c
        static string strCon = "Data Source = HuongDuong ; Initial Catalog = Hanghoa ; Integrated Security = True";
        static void LuuDB(List<hanghoa> l)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            //string txtSQLcreate = "INSERT INTO Sim(SimID, SoSim, NgayKichHoat, NgayHetHan, GhiChu) VALUES(@SimID, @SoSim, @NgayKichHoat, @NgayHetHan, @GhiChu)";
            foreach (hanghoa h in l)
            {
                try
                {
                    con.Open();
                    string txtSQLcreate = "INSERT INTO tblhanghoa(ID, MaVach, Ten, GiaNhap, GiaBan, GhiChu) VALUES (@a, @b, @c, @d, @e, @f);"; // Neu dung $ them thang value vao thi loi -> So khong du bao mat -> Dung @ 
                    SqlCommand cmd = new SqlCommand(txtSQLcreate, con);//lưu trữ câu lệnh SQL cần thực thi cùng với kết nối đến cơ sở dữ liệu.(data + @dich + tim duong)
                    cmd.Parameters.AddWithValue("@a", h.ID);
                    cmd.Parameters.AddWithValue("@b", h.MaVach);
                    cmd.Parameters.AddWithValue("@c", h.Ten);
                    cmd.Parameters.AddWithValue("@d", h.GiaNhap);
                    cmd.Parameters.AddWithValue("@e", h.GiaBan);
                    cmd.Parameters.AddWithValue("@f", h.GhiChu);
                    cmd.ExecuteNonQuery(); // thực thi các lệnh SQL không trả về dữ liệu
                    Console.WriteLine("Thao tac insert thanh cong!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Khong the thuc hien tac vu insert.\n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        static void run_3c_LuuDB()
        {
            List<hanghoa> l = inputListHanghoa(3);
            LuuDB(l);
        }

        //3d_DE3
        static void SQLtoJSON(string nameFile)
        {
            List<hanghoa> data = new List<hanghoa>();
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                // Mở kết nối
                connection.Open();
                // Câu lệnh SQL để truy vấn dữ liệu từ bảng Sim
                string query = "SELECT * FROM tblhanghoa";

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
                            hanghoa h = new hanghoa(
                                reader["ID"].ToString(), // SQL string 
                                reader["MaVach"].ToString(),
                                reader["Ten"].ToString(),
                                Convert.ToSingle(reader["GiaNhap"]), // SQL float 
                                Convert.ToSingle(reader["GiaBan"]),
                                reader["GhiChu"].ToString()
                            );
                            // Thêm đối tượng Sim vào danh sách
                            data.Add(h);
                        }
                    }
                }
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
        static void run_3d_DE3_SQLtoJSON()
        {
            string nameFile = "D:\\CODE_Study_CMC\\CSharp\\DeThiCuoiKi3CSharp\\De3\\hanghoa.json";
            SQLtoJSON(nameFile);
        }

        //3d_DE4 
        static void SQLtoCSV(string nameFile)
        {
            List<hanghoa> data = new List<hanghoa>();
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                // Mở kết nối
                connection.Open();
                // Câu lệnh SQL để truy vấn dữ liệu từ bảng Sim
                string query = "SELECT * FROM tblhanghoa";

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
                            hanghoa h = new hanghoa(
                                reader["ID"].ToString(), // SQL string 
                                reader["MaVach"].ToString(),
                                reader["Ten"].ToString(),
                                Convert.ToSingle(reader["GiaNhap"]), // SQL float 
                                Convert.ToSingle(reader["GiaBan"]),
                                reader["GhiChu"].ToString()
                            );
                            // Thêm đối tượng Sim vào danh sách
                            data.Add(h);
                        }
                    }
                }
            }
            if(data == null)
            {
                Console.WriteLine("NULL");
            }
            FileStream st = new FileStream(nameFile, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(st);
            foreach (hanghoa h in data)
            {
                sw.WriteLine($"{h.ID}, {h.MaVach}, {h.Ten}, {h.GiaBan}, {h.GiaNhap}, {h.GhiChu}");
                Console.WriteLine(($"{h.ID}, {h.MaVach}, {h.Ten}, {h.GiaBan}, {h.GiaNhap}, {h.GhiChu}"));
            }
            Console.WriteLine("Ghi vao file CSV thanh congg.");
            sw.Close();
        }
        static void run_3d_DE4_SQLtoCSV()
        {
            string nameFile = "D:\\CODE_Study_CMC\\CSharp\\DeThiCuoiKi3CSharp\\De3\\hanghoa.csv";
            SQLtoCSV(nameFile);
        }

        //3d_DE5
        static void run_3d_DE5()
        {
            List<hanghoa> l = inputListHanghoa(3);
            Task t = Task.Run(() =>
            {
                LuuDB(l);
            });
            t.Wait();
        }

        //3d_DE6
        static async Task LuuDB_task(List<hanghoa> l)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            //string txtSQLcreate = "INSERT INTO Sim(SimID, SoSim, NgayKichHoat, NgayHetHan, GhiChu) VALUES(@SimID, @SoSim, @NgayKichHoat, @NgayHetHan, @GhiChu)";
            foreach (hanghoa h in l)
            {
                try
                {
                    con.Open();
                    string txtSQLcreate = "INSERT INTO tblhanghoa(ID, MaVach, Ten, GiaNhap, GiaBan, GhiChu) VALUES (@a, @b, @c, @d, @e, @f);"; // Neu dung $ them thang value vao thi loi -> So khong du bao mat -> Dung @ 
                    SqlCommand cmd = new SqlCommand(txtSQLcreate, con);//lưu trữ câu lệnh SQL cần thực thi cùng với kết nối đến cơ sở dữ liệu.(data + @dich + tim duong)
                    cmd.Parameters.AddWithValue("@a", h.ID);
                    cmd.Parameters.AddWithValue("@b", h.MaVach);
                    cmd.Parameters.AddWithValue("@c", h.Ten);
                    cmd.Parameters.AddWithValue("@d", h.GiaNhap);
                    cmd.Parameters.AddWithValue("@e", h.GiaBan);
                    cmd.Parameters.AddWithValue("@f", h.GhiChu);
                    cmd.ExecuteNonQuery(); // thực thi các lệnh SQL không trả về dữ liệu
                    Console.WriteLine("Thao tac insert thanh cong!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Khong the thuc hien tac vu insert.\n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        static async Task Main_DE6(string[] args)
        {
            List<hanghoa> l = inputListHanghoa(3);
            await LuuDB_task(l); // Gọi hàm async để thực hiện thao tác ghi vào cơ sở dữ liệu
            Console.WriteLine("Task đã thực hiện xong"); // Thông báo khi thực hiện xong
        }
    }
}
