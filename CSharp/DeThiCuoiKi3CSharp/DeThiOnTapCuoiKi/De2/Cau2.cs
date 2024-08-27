using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

/*
Khai báo các lớp Customer, Order như sau trong mã nguồn chương trình:  
class Customer  
{  
    public string CustomerID { get; set; }  
    public string Name { get; set; }  
    public string Address { get; set; }  
    public string Email { get; set; }  
}  
class Order  
{  
    public string OrderID { get; set; }  
    public string CustomerID { get; set; }  
    public string Product { get; set; }  
    public int Quantity { get; set; }  
}  
Viết hàm NhapCustomer, NhapOrder với tham số phù hợp để nhập dữ liệu vào 2 bảng Customer, Order 
có chặn Exception. Gọi hàm NhapCustomer, NhapOrder trong hàm Main() để kiểm tra. 
 */

namespace De2
{
    internal class Cau2
    {
        static void Main(string[] args)
        {
            List<Customer> c = input_Customer(3);
            NhapCustomer(c);
        }
        public class Customer
        {
            public string CustomerID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public Customer(string a, string b, string c, string d)
            {
                CustomerID = a; Name = b; Address = c; Email = d;
            }
        }
        public class Order
        {
            public string OrderID { get; set; }
            public string Product { get; set; }
            public int Quantity { get; set; }
            public string CustomerID { get; set; }
            public Order(string a, string b, int d, string c)
            {
                OrderID = a; Product = b; CustomerID = c;Quantity = d;
            }
        }
        static List<Customer> input_Customer(int n)
        {
            List<Customer> l = new List<Customer>();
            while (n != 0)
            {
                // CustomerID: kiểu xâu, độ dài cố định, lưu chuỗi 10 chữ số, là khóa chính  
                string id = "";
                while (true)
                {
                    Console.Write("Nhap vao CustomerID: ");
                    id = Console.ReadLine();
                    try
                    {
                        int.Parse(id);
                        if (id.Length == 10)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nhap vao chuoi 10 chu so.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Nhap vao chuoi 10 chu so. \n" + e.ToString());
                    }
                }
                // Name: kiểu string, độ dài thay đổi, lưu được tiếng Việt
                Console.Write("Name: ");
                string name = Console.ReadLine();
                // Address: kiểu string, độ dài thay đổi, lưu được tiếng Việt
                Console.Write("Address: ");
                string add = Console.ReadLine();
                // Email: kiểu string, độ dài thay đổi.
                Console.Write("Email: ");
                string email = Console.ReadLine();
                try
                {
                    Customer c = new Customer(id, name, add, email);
                    l.Add(c);
                    n--;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return l;
        }
        static string strCon = "Data Source = HuongDuong ; Initial Catalog = Sales ; Integrated Security = True";
        public static void NhapCustomer(List<Customer> list)
        {
            SqlConnection con = new SqlConnection(strCon);
            foreach (Customer l in list)
            {
                try
                {
                    con.Open();
                    string txt = $"insert into Customers(CustomerID, Name, Address, Email) values (@a, @b, @c, @d);";
                    SqlCommand cmd = new SqlCommand(txt, con);
                    cmd.Parameters.AddWithValue("@a", l.CustomerID);
                    cmd.Parameters.AddWithValue("@b", l.Name);
                    cmd.Parameters.AddWithValue("@c", l.Address);
                    cmd.Parameters.AddWithValue("@d", l.Email);
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
        static List<Order> input_Order(int n)
        {
            List<Order> l = new List<Order>();
            while (n != 0)
            {
                //OrderID: kiểu xâu, độ dài cố định, lưu chuỗi 10 chữ số, là khóa chính
                string id;
                while (true)
                {
                    Console.Write("ID: ");
                    id = Console.ReadLine();
                    try
                    {
                        int.Parse(id);
                        if (id.Length == 10)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nhap vao id la chuoi 10 chu so .");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Nhap vao id la chuoi 10 chu so .\n" + e.ToString());
                    }
                }
                //Product: kiểu string, độ dài thay đổi tối đa 50 kí tự
                string product;
                while (true)
                {
                    Console.Write("Product: ");
                    product = Console.ReadLine();
                    if (product.Length <= 50)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nhap vao product co toi da 50 ki tu.");
                    }
                }
                //Quantity: kiểu số nguyên
                int quantity;
                while (true)
                {
                    Console.Write("Quantity = ");
                    string x = Console.ReadLine();
                    try
                    {
                        int.TryParse(x, out quantity);
                        if (quantity >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nhap so nguyen.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
                //CustomerID: kiểu số nguyên là khóa ngoài của Customers(CustomerID)
                // CustomerID: kiểu xâu, độ dài cố định, lưu chuỗi 10 chữ số, là khóa chính  
                string idcus = "";
                while (true)
                {
                    Console.Write("Nhap vao CustomerID: ");
                    id = Console.ReadLine();
                    try
                    {
                        int.Parse(id);
                        if (id.Length == 10)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nhap vao chuoi 10 chu so.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Nhap vao chuoi 10 chu so. \n" + e.ToString());
                    }
                }
                Order o = new Order(id, idcus, quantity, product);
                try
                {
                    l.Add(o);
                    n--;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return l;
        }
        public static void NhapOrder(List<Order> list)
        {
            SqlConnection con = new SqlConnection(strCon);
            foreach (Order l in list)
            {
                try
                {
                    con.Open();
                    string txt = "insert into Orders(OrderID, Product, Quantity, CustomerID) values (@a, @b, @c, @d);";
                    SqlCommand cmd = new SqlCommand(txt, con);
                    cmd.Parameters.AddWithValue("@a", l.OrderID);
                    cmd.Parameters.AddWithValue("@b", l.Product);
                    cmd.Parameters.AddWithValue("@c", l.Quantity);
                    cmd.Parameters.AddWithValue("@d", l.CustomerID);
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
    }
}
