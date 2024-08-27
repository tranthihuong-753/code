using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSharpFilejson
{
    internal class Program
    {
        // Ghi file json 
        // Sau khi ghi phai close de giai phong tai nguyen , neu khong thi khong them vao duoc 
        static void writeJson(string nameFile, List<Animal> data)
        {
            try
            {
                // Chuyển đổi danh sách thành chuỗi JSON
                string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });

                // Ghi chuỗi JSON vào tệp bằng StreamWriter
                using (StreamWriter sw = new StreamWriter(nameFile))
                {
                    sw.Write(json);
                }

                Console.WriteLine($"Đã ghi danh sách vào tệp JSON '{nameFile}' thành công.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Lỗi IO: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Lỗi truy cập không được ủy quyền: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            /*
            // Chuyển đổi danh sách thành chuỗi JSON
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });

            
            try
            {
                // Kiểm tra xem tệp đã tồn tại chưa
                if (File.Exists(nameFile))
                {
                    // Đọc nội dung hiện tại của tệp
                    string existingJson = File.ReadAllText(nameFile);
                    Console.WriteLine(existingJson);
                    // Xóa ký tự cuối cùng va len dong (đó là dấu đóng mảng ']' của JSON hiện tại)
                    existingJson = existingJson.Substring(0, existingJson.Length - 3);
                    Console.WriteLine("sau: "+existingJson);
                    // Nếu tệp không rỗng, thêm dấu phẩy để ngăn cách giữa các mảng JSON
                    if (!string.IsNullOrEmpty(existingJson))
                    {
                        existingJson += ",";
                    }
                    // Ghép chuỗi JSON mới vào nội dung hiện tại của tệp
                    json = existingJson + json.Substring(1); // Bỏ qua dấu mở mảng '[' của JSON mới
                }

                // Ghi chuỗi JSON vào tệp
                File.WriteAllText(nameFile, json);

                Console.WriteLine($"Đã ghi danh sách vào tệp JSON '{nameFile}' thành công.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Lỗi IO: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Lỗi truy cập không được ủy quyền: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            */
            //if (File.Exists(nameFile))
            //{
            //    //Console.WriteLine(data.Count);
            //    // Chuyển đổi danh sách thành chuỗi JSON
            //    string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            //    //Console.WriteLine(json.Length);

            //    // Ghi chuỗi JSON vào tệp
            //    //Them true la ghi tiep vao file json 
            //    StreamWriter sw = new StreamWriter(nameFile, true);
            //    //Console.WriteLine("ban dau: "+sw.ToString());
            //    sw.WriteLine(json);
            //    sw.Close();
            //    //Console.WriteLine("sw sau: " + sw.ToString());
            //    //Console.WriteLine("json sau: " + json.ToString());
            //}
            //else
            //{
            //    //Console.WriteLine(data.Count);
            //    // Chuyển đổi danh sách thành chuỗi JSON
            //    string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            //    //Console.WriteLine(json.Length);
            //    // Ghi chuỗi JSON vào tệp
            //    //FileStream st = new FileStream(nameFile, FileMode.Append, FileAccess.Write);
            //    StreamWriter sw = new StreamWriter(nameFile);
            //    //Console.WriteLine("ban dau: "+sw.ToString());
            //    sw.WriteLine(json);
            //    sw.Close();
            //    //Console.WriteLine("sw sau: " + sw.ToString());
            //    //Console.WriteLine("json sau: " + json.ToString());
            //}

        }
        // Doc file json 
        // Lop Animal 
        public class Animal
            {
                public string Name { get; set; }
                public double Age { get; set; }
            //public Animal(string name, double age)
            //{
            //    Name = name;
            //    Age = age;
            //}
        }
        // Ham tao va tra ve List<Animal>
        //static List<Animal> list()
        //{
            static List<Animal> animals = new List<Animal>
            {
                //new Animal { Name = "Capybara", Age = 1 },
                //new Animal { Name = "Dog", Age = 2.4 },
                //new Animal { Name = "Mouse", Age = 2.3 },
                //new Animal { Name = "Human", Age = 1.3 }
                new Animal { Name = "h", Age = 2 },
                new Animal { Name = "ouse", Age = 1.2 }
            };
        //    return animals;
        //}
        static void Main(string[] args)
        {
            writeJson("filejson.json", animals);

        }
    }
}
