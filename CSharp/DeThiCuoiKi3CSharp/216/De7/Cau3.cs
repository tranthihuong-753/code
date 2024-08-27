using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace De7
{
    internal class Cau3
    {
        //static void Main(string[] args)
        //{
        //    //run_3a_3b_cdNAM();
        //    //run_3a_3c_ghivaoDB();
        //    //run_3d_SQLtoCSV();
        //}
        //3a 
        static Dictionary<string, CongDan> inputCD(int n)
        {
            Dictionary<string, CongDan> d = new Dictionary<string, CongDan>();
            int m = 0;
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Random random = new Random();
            while (m < n)
            {
                Console.ForegroundColor = colors[random.Next(colors.Length)];
                Console.WriteLine($"Nhap vao ban ghi Cong Dan {m+1}");
                //--    MaCD: String, độ dài cố định, lưu chuỗi 9 chữ số, là khóa chính; 
                string macd;
                while (true)
                {
                    Console.Write("Ma Cong Dan <Muon dung nhap thi nhap '#'> : ");
                    macd = Console.ReadLine();
                    if(macd == "#")
                    {
                        return d;
                    }
                    int w = 0; // macd co do dai 9 
                    if(macd.Length != 9)
                    {
                        Console.WriteLine("!!! Ma CD co do dai 9.");
                        w = 1;
                    }
                    if(w == 1)
                    {
                        continue;
                    }
                    try
                    {
                        int.Parse(macd);
                        // Khong ton tai trong dic
                        int e = 0; // khong ton tai trong dic 
                        foreach (CongDan c in d.Values)
                        {
                            if (macd == c.MaCD)
                            {
                                e = 1;
                                break;
                            }
                        }
                        if(e == 1)
                        {
                            Console.WriteLine("MA CD da ton tai.");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                //--    TenCD: String(độ dài không quá 200), có thể lưu dữ liệu unicode Tiếng Việt; 
                Console.Write("Ten : ");
                string ten= Console.ReadLine();
                //--    CCCD: String, độ dài cố định, lưu chuỗi 12 chữ số(có thể đặt là khóa ngoài); 
                string CCCD;
                while (true)
                {
                    Console.Write("CCCD: ");
                    CCCD = Console.ReadLine();
                    int q = 0; // do dai 12 ki tu 
                    if(CCCD.Length != 12)
                    {
                        Console.WriteLine("CCCD co do dai 12 ky tu.");
                        q = 1; 
                    }
                    if(q == 1)
                    {
                        continue;
                    }
                    // check CCCD trong dictionary
                    int i = 0; // CCCD khong ton tai trong dictionary 
                    foreach(CongDan c in d.Values)
                    {
                        if(CCCD == c.CCCD)
                        {
                            Console.WriteLine("CCCD da ton tai .");
                            i = 1;
                        }
                    }
                    if(i == 1)
                    {
                        continue;
                    }
                    // Chuyen doi sang int 
                    try
                    {
                        double.Parse(CCCD);
                        break;
                    }catch(Exception e)
                    {
                        Console.WriteLine (e.Message);
                    }
                }
                //--    GioiTinh: String, lưu được 3 giá trị “Nam/Nữ/Không xác định; 
                string gt;
                while (true)
                {
                    Console.Write("Gioi Tinh <Nhap vao 0/1/2 voi 0-Nam, 1-Nu, 2-Khong xac dinh> : ");
                    gt = Console.ReadLine();
                    try
                    {
                        int x = int.Parse(gt);
                        if(x == 0)
                        {
                            gt = "Nam";
                        }else if(x == 1)
                        {
                            gt = "Nu";
                        }
                        else
                        {
                            gt = "Khong xac dinh";
                        }
                        break;
                    }catch(Exception e)
                    {
                        Console.WriteLine("Vui long nhap 0/1/2.\n" + e.Message);
                    }
                    
                }
                //--    NgaySinh: String, hoặc kiểu date.
                DateTime ns;
                while (true)
                {
                    Console.Write("Ngay sinh <YYYY-mm-DD>: ");
                    string x = Console.ReadLine();
                    try
                    {
                        ns = DateTime.Parse(x);
                        break;
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                // Them vao dic
                CongDan cd = new CongDan(macd, ten, CCCD, gt, ns);
                try
                {
                    d.Add(macd, cd);
                    m++;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return d;
        }
        //3b
        static void run_3a_3b_cdNAM()
        {
            // 3a Gọi hàm trong hàm Main() để lấy các đối tượng công dân lưu vào biến CongDan1. 
            Dictionary<string, CongDan> CongDan1 = inputCD(3);
            // 3b Viết câu lệnh duyệt CongDan1 để hiển thị các công dân nữ. 
            Console.WriteLine("Cong Dan NAM: ");
            foreach(CongDan a  in CongDan1.Values)
            {
                if(a.GioiTinh == "Nam")
                {
                    Console.WriteLine($"Ma: {a.MaCD}, Ten: {a.TenCD}, CCCD: {a.CCCD}, GT: {a.GioiTinh}, NS: {a.NgaySinh}");
                }
            }
        }
        //3c
        static string strCon = "Data Source = HuongDuong ; Initial Catalog = DieuTraDS ; Integrated Security = True";
        static string LuuDB(Dictionary<string, CongDan> data)
        {
            SqlConnection con = new SqlConnection(strCon);
            foreach (CongDan c in data.Values)
            {
                try
                {
                    con.Open();
                    string txt = $"insert into CongDan(MaCD, TenCD, CCCD, GioiTinh, NgaySinh) values (@a, @b, @c, @d, @e);";
                    SqlCommand cmd = new SqlCommand(txt, con);
                    cmd.Parameters.AddWithValue("@a", c.MaCD);
                    cmd.Parameters.AddWithValue("@b", c.TenCD);
                    cmd.Parameters.AddWithValue("@c", c.CCCD);
                    cmd.Parameters.AddWithValue("@d", c.GioiTinh);
                    cmd.Parameters.AddWithValue("@e", c.NgaySinh);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("INSERT thanh cong.");
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }
            return "";
        }
        static void run_3a_3c_ghivaoDB()
        {
            //3a
            Dictionary<string, CongDan> CongDan1 = inputCD(3);
            // 3b Viết câu lệnh duyệt CongDan1 để hiển thị các công dân nữ. 
            Console.WriteLine("Cong Dan NAM: ");
            foreach (CongDan a in CongDan1.Values)
            {
                if (a.GioiTinh == "Nam")
                {
                    Console.WriteLine($"Ma: {a.MaCD}, Ten: {a.TenCD}, CCCD: {a.CCCD}, GT: {a.GioiTinh}, NS: {a.NgaySinh}");
                }
            }
            //3c
            LuuDB(CongDan1);
        }
        //3d
        static async Task LuuDB_task(Dictionary<string, CongDan> data)
        {
            SqlConnection con = new SqlConnection(strCon);
            foreach (CongDan c in data.Values)
            {
                try
                {
                    con.Open();
                    string txt = $"insert into CongDan(MaCD, TenCD, CCCD, GioiTinh, NgaySinh) values (@a, @b, @c, @d, @e);";
                    SqlCommand cmd = new SqlCommand(txt, con);
                    cmd.Parameters.AddWithValue("@a", c.MaCD);
                    cmd.Parameters.AddWithValue("@b", c.TenCD);
                    cmd.Parameters.AddWithValue("@c", c.CCCD);
                    cmd.Parameters.AddWithValue("@d", c.GioiTinh);
                    cmd.Parameters.AddWithValue("@e", c.NgaySinh);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("INSERT thanh cong.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Task1");
            //3a
            Dictionary<string, CongDan> CongDan1 = inputCD(3);
            //3c
            await LuuDB_task(CongDan1);
            Console.WriteLine("Task đã thực hiện xong.");
        }

    }
}
