using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCodeFirst
{
    internal class Program
    {
        public class SanPham
        {
            // Khóa chính của bảng SanPham, được tự động sinh ra khi thêm mới bản ghi
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            // Tên của sản phẩm, với độ dài tối đa là 100 ký tự, sử dụng kiểu dữ liệu nvarchar
            [StringLength(100)]
            [Column(TypeName = "nvarchar")]
            public string TenSanPham { get; set; }

            // Khóa ngoại liên kết đến bảng NhaCungCap, thể hiện mối quan hệ giữa sản phẩm và nhà cung cấp
            [ForeignKey("NhaCungCap")]
            public int NhaCungCapId { get; set; }

            // Giá của sản phẩm, sử dụng kiểu dữ liệu decimal để lưu trữ giá trị số chính xác
            [Column(TypeName = "decimal")]
            public decimal Gia { get; set; }

            // Ghi chú thêm về sản phẩm, sử dụng kiểu dữ liệu nvarchar
            [Column(TypeName = "nvarchar")]
            public string GhiChu { get; set; }

            // Mối quan hệ với bảng NhaCungCap, cho phép truy xuất thông tin nhà cung cấp liên kết
            //public virtual NhaCungCap NhaCungCap { get; set; }
        }
        public class Context : DbContext
        {
            public Context() : base("name=CodeFirst_connectionString")
            {
            }
            public DbSet<SanPham> SanPham;
        }
        static void vd1_CreateDB()
        {
            try
            {
                using (var context = new Context())
                {
                    context.Database.CreateIfNotExists();
                }
                Console.WriteLine("Create thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static void vd2_Insert()
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();
                var person = new Person
                {
                    FirstName = "Donald",
                    LastName = "Trump"
                };
                context.PeopleHD.Add(person);
                context.SaveChanges();
                Console.WriteLine("Insert successfull");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            vd1_CreateDB();
        }
    }
}
