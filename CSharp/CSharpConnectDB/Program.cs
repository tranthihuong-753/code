using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConnectDB
{
    internal class Program
    {
        // Connect toi CSDL tren may minh de tao bang 
        // Data Source : Server Properties -> Name 
        // Initial Catalog : ten CSDL da tao  
        // True có nghĩa là Su dung windows authentication để xác thực mà không cần cung cấp tên người dùng và mật khẩu riêng.
        // Cac tu "Data Source", "Initial Catalog", "Integrated Security = True" khong duoc thay doi 
        static string strCon = "Data Source = BuonBuonVuiVui ; Initial Catalog = CSDLdemo ; Integrated Security = True";
        //Data Source=DESKTOP-LFCPKOB;Initial Catalog=QLMUONSACH;Integrated Security=True
        //Data Source=DESKTOP-LFCPKOB;Initial Catalog=QLMUONSACH;Persist Security Info=True;User ID=he;Password = 1234
        //Data Source = BuonBuonVuiVui ; Initial Catalog = CSDLdemo ; Integrated Security = True
        static void createTable()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            try
            {
                string strSql = "create table student(id int not null, name varchar(100), email varchar(50), join_data date)";
                SqlCommand cm = new SqlCommand(strSql, con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Tao moi thanh cong!");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("LỖI");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        // Them moi du lieu 
        static void insert()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            try
            {
                string strSql = "INSERT INTO student (id, name, email, join_date) VALUES (1, 'Nguyen Van B', 'nguyenvana@example.com', '2023-07-15')";
                SqlCommand cm = new SqlCommand(strSql, con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Them moi du lieu thanh cong!");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("LỖI");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        // Lay ra all ban ghi
        static void retrieve()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            try
            {
                string strSql = "select * from student";
                SqlCommand cm = new SqlCommand(strSql, con);
                con.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                while(sdr.Read())
                {
                    Console.WriteLine(sdr["id"]+" " + sdr["name"]+" " + sdr["email"]);
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("LỖI");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        // Xoa du lieu 
        static void delete()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;
            try
            {
                string strSql = "delete from student where id = '104'";
                SqlCommand cm = new SqlCommand(strSql, con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Xoa du lieu thanh cong!");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("LỖI");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}