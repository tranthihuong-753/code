using Amazon.Runtime.CredentialManagement.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//1. Ke thua 
/*
namespace CSharpClass23IT4
{
    // Lop loai nguoi 
    class Person
    {
        protected int ID;
        protected string Name;
        // Ham tao 
        public Person(int id, string name)
        {
            ID = id;
            Name = name;
        }
        // Ham in ra thong tin 
        public void show()
        {
            Console.WriteLine($"IDloainguoi : {ID}\nNameloainguoi : {Name}");
        }
    }
    // Lop sinh vien  
    class Uni : Person
    {
        protected string uni;
        protected int sumStudent;
        //Ham tao 
        public Uni(int id, string name, string u, int sum): base(id, name)
        {
            uni = u;
            sumStudent = sum;
        }
        //Ham hien thi 
        public void showUni()
        {
            base.show();
            Console.WriteLine($"Name uni: {uni}\nSum student: {sumStudent}");
        }
    }
    // Lop khoa sinh vien 
    class DepartmentStudent : Uni
    {
        protected string nameDepartmentS;
        // Ham tao
        public DepartmentStudent(int id, string name, string u, int sum, string nameD) : base(id, name, u, sum)
        {
            nameDepartmentS = nameD;
        }
    }
    // Lop khoa giang vien
    class DepartmentTeacher : Uni
    {
        protected string nameDepartmentT;
        // Ham tao 
        public DepartmentTeacher(int id, string name, string u, int sum, string nameDT) : base(id, name, u, sum)
        {
            nameDepartmentT = nameDT;
        }
    }
    internal class exp
    {

    }
}
*/
//2. Liet ke enum 
/*
// enum de trong / ngoai namespace , trong internal deu duoc ??? , cach su dung thi y nhau , m cai mon CSharp nay 
namespace CSharpClass23IT4
{
    enum giaToc
    {
        Papa, conGai, cauDepTrai, conRe
    }
    internal class exp
    {
        //// class
        //enum giaToc
        //{
        //     Papa , conGai , cauDepTrai , conRe
        //}
        static void useEnum(giaToc gt)
        {
            switch (gt)
            {
                case giaToc.Papa:
                    Console.WriteLine("doi day.");
                    break;
                case giaToc.conGai:
                    Console.WriteLine("Dang yeu, xinh gai, cham hoc, quan tam toi ban be la thu ai day khong co.");
                    break;
                case giaToc.cauDepTrai:
                    Console.WriteLine("Ummmmm chen duoc cai anh mang thong diep di vao day la dep. T se tim hieu vu nay");
                    break;
                case giaToc.conRe:
                    Console.WriteLine("ho");
                    break;
                default:
                    break;
            }
        }
        //main
        static void Main(string[] args)
        {
            useEnum(giaToc.conGai);    
        }
    }
}
// class
//enum giaToc
//{
//    Papa, conGai, cauDepTrai, conRe
//}
*/
//Mang array 
/*
namespace CSharpClass23IT4
{
    internal class exp
    {
        // Nhap vao va tra ve mang 1 chieu so nguyen
        int[] arrInt(int n)
        {
            // Nhap vao 
            int[] arr = new int[n];
            return arr;
        }
        //// Nhap vao mot so nguyen duong 
        //public int OneInt()
        //{
        //    int x;
        //    try
        //    {
        //        x = int.Parse(Console.ReadLine());
        //        if(x>0)
        //        {
        //            return x;
        //        }
        //        else
        //        {
        //            Console.WriteLine("So nhap vao phai lon hon 0.");
        //        }
        //    }
        //    catch(Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //}
        static void Main(string[] args)
        {

        }
    }
}
*/
//Dictionary 
/*
namespace CSharpClass23IT4
{
    class exp
    {
        // Dictionary - sort no order - O(1)
        static void dicNoOrder()
        {
            // Mac dinh cot dau nhu ID cua DIctionary, khong giong nhau 
            Dictionary<string, string> mydic = new Dictionary<string, string>();
            mydic.Add("S1", "Lap tring CSharp");
            mydic.Add("S2", "Lap tring C");
            mydic.Add("S3", "Tri tue nhan tao");

            //mydic.Add("S3", "Tri tue nhan ");
            //mydic.Add("S4", "Tri tue nhan tao");
            foreach (KeyValuePair<string, string> item in mydic)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
        // SortedDictionary<?, ?>() - order sort  - O(logn) - mac dinh cot dau la khoa 
        static void dicOrder()
        {
            // Khai bao va khoi tao mot dictionary co sap xep theo thu tu , mac dinh cot dau (string) la khoa 
            SortedDictionary<int, decimal> sortDic = new SortedDictionary<int, decimal>();
            // Them gia tri 
            sortDic.Add(4, 1.12345678m);
            sortDic.Add(2, 2.12345678901234567890m);
            sortDic.Add(3, 3.1234567890123456789012345678941234567890m); // output 8.1234567
            // In ra bang console
            Console.WriteLine("Các phần tử trong SortedDictionary:");
            foreach (KeyValuePair<int, decimal> x in sortDic)
            {
                Console.WriteLine($"Key = {x.Key} and Value = {x.Value}");
            }
        }
        // SortedDictionary<?, ?>(IComparer) - Co the in ra theo khoa co thu tu giam dan 
        static void dicOrderCrazy()
        {
            // Tạo một IComparer tùy chỉnh sử dụng Comparison delegate
            IComparer<string> comparer = Comparer<string>.Create((x, y) => y.CompareTo(x));

            // Khai báo và khởi tạo một SortedDictionary với khóa là string và giá trị là int
            // Sử dụng IComparer tùy chỉnh để so sánh các khóa
            SortedDictionary<string, int> sortDic = new SortedDictionary<string, int>(Comparer<string>.Create((x, y) => y.CompareTo(x)));

            // Thêm giá trị
            sortDic.Add("a", 1);
            sortDic.Add("b", 2);
            sortDic.Add("c", 3);

            // In ra bằng console
            Console.WriteLine("Các phần tử trong SortedDictionary (sắp xếp theo thứ tự ngược):");
            foreach (KeyValuePair<string, int> kvp in sortDic)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
        static void Main(string[] args)
        {
           
        }
    }
}
*/
// 0 - 9
/*
namespace CSharpClass23IT4
{
    internal class exp
    {
        // choi choi switch case default
        static void vd()
        {
            int x = -1;
            // Luon chay cho den khi bap break; 
            while (true)
            {
                try
                {
                    x = int.Parse(Console.ReadLine());
                    if(x >= 0 && x <= 9)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("!!! Nhap vao so nguyen duong tu 0 den 9.");
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            vd();
        }
    }
}
*/
// Tree 
/*
// Algorithm 
namespace CSharpClass23IT4
{
    internal class exp
    {
        // node
        class node
        {
            public int value;
            public node left, right;
            public node(int x)
            {
                value = x;
            }
        }
        // Tu day la lop tao 
        class myTree
        {
            public node root;
            // Ham hien thi 
            public void visit(node p)
            {
                if (p == null)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("     " + p.value);
                }
            }
            // Kiem tra xem cay co phai la full tree 
            public Boolean checkFull = true;
            public void checkFullTree(node p)
            {
                if (p == null)
                {
                    return;
                }
                if (!((p.left == null && p.right == null) || (p.left != null && p.right != null)))
                {
                    checkFull = false;
                }
                if (checkFull == true)
                {
                    checkFullTree(p.left);
                    checkFullTree(p.right);
                }
            }
            // Kiem tra xem cay co phai la completed tree
            public Boolean checkCom = true;
            public void checkComTree(node p)
            {
                
            }
            public void helpcheckComTree(Queue<node> qu, node p, int k)
            {
                for (int i = 0; i < Math.Pow(2, k); i++) // i tu 0 den (2^k - 1)
                {
                    
                }
            }
            static void Main(string[] args)
            {
                myTree tree = new myTree();
                tree.root = new node(1);
                tree.root.left = new node(2);
                tree.root.right = new node(3);
                tree.root.left.left = new node(4);
                tree.root.left.right = new node(5);
                tree.root.right.left = new node(6);
                tree.root.right.right = new node(7);
                tree.root.right.left.left = new node(8);
                tree.root.right.left.right = new node(9);

                //Console.WriteLine("Check bd : " + tree.checkFull);
                //tree.checkFullTree(tree.root);
                //Console.WriteLine("Check sau : " + tree.checkFull);
            }
        }
    }
}


*/
// Connect Database 
/*
namespace CSharpClass23IT4
{
    // Ket noi toi CSDL tren may khac orthers host 
    internal class connectDBMany
    {
        static string nameDB = "hoa";
        static string ID = "HuongDuong";
        static string Pass = "123";
        static string Lap = $"Data Source = DESKTOP-664P363\\SQLEXPRESS; Database = {nameDB};Persist Security Info=True ; User ID={ID}; Password={Pass}";
        //DESKTOP-664P363\SQLEXPRESS  192.168.105.16
        //// Ham tao co so du lieu 
        //// Ham tao co so du lieu . Input : ten bang 
        //static void createDB(string nameDB)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = Lap;
        //    try
        //    {
        //        con.Open();
        //        string txtSQLcreate = $"create database {nameDB}";
        //        SqlCommand cmd = new SqlCommand(txtSQLcreate, con);//lưu trữ câu lệnh SQL cần thực thi cùng với kết nối đến cơ sở dữ liệu.(data + @dich + tim duong)
        //        cmd.ExecuteNonQuery(); // thực thi các lệnh SQL không trả về dữ liệu
        //        Console.WriteLine($"Tao moi Database {nameDB} thanh cong!");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        // Ham tao bang, tao ban ghi. Input : Cau lenh SQL 
        static void thaoTac(string txtSQLcreate)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Lap;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(txtSQLcreate, con);//lưu trữ câu lệnh SQL cần thực thi cùng với kết nối đến cơ sở dữ liệu.(data + @dich + tim duong)
                cmd.ExecuteNonQuery(); // thực thi các lệnh SQL không trả về dữ liệu
                Console.WriteLine("Thao tac thanh cong!");
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
        static void vd1()
        {
            string txtSqlcreate = "create table Category(\r\n\tIDCategory int identity(0, 1) primary key,\r\n\tNameCategory nvarchar(100) not null,\r\n\tStatus tinyint default 1 check(Status in(0, 1)) \r\n)";

            thaoTac(txtSqlcreate);
        }
        static void Main(string[] args)
        {
            vd1();
        }
    }

}
*/
//Entity Framework - First code 
namespace CSharpClass23IT4
{
    internal class entityKeoTha
    {

        static void Main(string[] args)
        {
            
        }
    }
    internal class entityTuTucLaHanhPhuc
    {
        // Nhớ có {get; set;}

        //CREATE TABLE NhaCungCap
        //    Id INT IDENTITY(1,1) PRIMARY KEY,
        //    TenNhaCungCap NVARCHAR(100) UNIQUE,
        //    SoDienThoai NVARCHAR(15) UNIQUE,
        //    DiaChi NVARCHAR(MAX),
        //    ThoiGianGiao DECIMAL(18, 2),
        //    GhiChu NVARCHAR(MAX),
        //    DiemUyTin DECIMAL(18, 2)
        //);
        public class NhaCungCap
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string SDT { get; set; }
            public string diachi { get; set; }
            public decimal thoigian { get; set; }
            public string ghichu { get; set; }
            public decimal diemuytin { get; set; }
        }
        //Dinh nghia lop 
        //CREATE TABLE SanPham (
        //    Id INT IDENTITY(1,1) PRIMARY KEY,
        //    TenSanPham NVARCHAR(100),
        //    NhaCungCapId INT,
        //    Gia DECIMAL(18, 2),
        //    GhiChu NVARCHAR(MAX),
        //    FOREIGN KEY(NhaCungCapId) REFERENCES NhaCungCap(Id) );
        public class SanPham
        {
            public int ID { get; set; }
            public string tensp { get; set; }
            public int idnhacungcap { get; set; }
            public decimal gia { get; set; }
            public string ghichu { get; set; }
        }
        public class btlcontext : DbContext
        {
            public btlcontext() : base("name=CodeFirst_connectionString_15082024") { } // add trong App.config 
            public DbSet<NhaCungCap> NhaCungCap { get; set; } 
            public DbSet<SanPham> SanPham { get; set; }

        }
        public static void create_database()
        {
            try
            {
                using(btlcontext c = new btlcontext())
                {
                    c.Database.CreateIfNotExists();
                }
                MessageBox.Show("Bat dau .");
            }catch(Exception ex)
            {
                MessageBox.Show("Loi . \n" + ex.Message); //using System.Windows.Forms;
            }
        }
        static void Main(string[] args)
        {
            create_database();
        }
    }
}
// Asynchronous programing - Lap trinh bat dong bo 

namespace CSharpClass23IT4
{
    internal class luong
    {
        // Ham set up mau
        static void setUpColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        static Task Color(ConsoleColor color, string luong)
        {
            Task tacVu = new Task(() =>
            {
                for (int i = 0; i < 23; i++)
                {
                    Console.ForegroundColor = color;
                    Thread.Sleep(500); // tạm dừng thực thi của luồng hiện tại trong 500 mili-giây (0.5 s)
                    Console.WriteLine(i + $" {luong}");
                    Console.ResetColor(); // Khong co dong nay thi chay het ham mau van la "color" nhe 
                }
            });
            return tacVu;
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Thu Di Gau");

            
            //dynamic x = "toi ";
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(x);
            //dynamic y = "yeu ";
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(y);
            //dynamic z = "chinh toi";
            //dynamic c = x + y * z;
            //Console.WriteLine(c);
            
        }
        static void Vd1()
        {
            Task luong1 = Color(ConsoleColor.Red, "luong 1");
            Task luong2 = Color(ConsoleColor.Blue, "luong 2");

            luong1.Start();
            //luong1.Wait(); // luong1 chay xong moi toi task khac 
            luong2.Start();

            // Đợi cả hai tác vụ hoàn thành
            Task.WaitAll(luong1, luong2);
        }

        static void Main(string[] args)
        {
            Vd1();
            
        }
    }
    internal class haha
    {
        static void Color(ConsoleColor color, string luong)
        {
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Thu Di Gau");
            for (int i = 0; i < 23; i++)
            {
                Console.ForegroundColor = color;
                Thread.Sleep(500); // Tạm dừng thực thi của luồng hiện tại trong 500 mili-giây (0.5 s)
                Console.WriteLine(i + $" {luong}");
                Console.ResetColor(); // Khong co dong nay thi chay het ham mau van la "color" nhe 
            }
        }

        static void Vd1()
        {
            Console.WriteLine("mi mi mi mi ");

            Task luong1 = Task.Run(() => Color(ConsoleColor.Red, "luong 1"));
            Task luong2 = Task.Run(() => Color(ConsoleColor.Blue, "luong 2"));

            // Đợi các task hoàn thành
            Task.WaitAll(luong1, luong2);
        }

        static void Main(string[] args)
        {
            Vd1();

            // Để chương trình không kết thúc ngay và có thể quan sát kết quả
            Console.ReadLine();
        }
    }
}

// Tự động sinh mã enum 
/*
namespace CSharpClass23IT4
{
    internal class TuDongHoaEnum
    {
        static void Main()
        {
            CreateEnumHelper.Create();
        }
    }

    public static class CreateEnumHelper
    {
        public static void Create()
        {
            string enumTemplate = @"
public enum SampleEnum
{
    Value1,
    Value2,
    Value3
}

public class Program
{
    static void Main(string[] args)
    {
        SampleEnum myValue = SampleEnum.Value1;
        Console.WriteLine($""Selected Value: {myValue}"");
    }
}";
            Console.WriteLine("Copy and paste the following code to create an enum:");
            Console.WriteLine(enumTemplate);
        }
    }


}
*/