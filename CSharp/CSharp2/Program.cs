//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp2
//{
//    internal class Program
//    {
//        // csv 
//        // Ham ghi csv 
//        static void vd1(string file, string[,] arr)
//        {
//            // Tạo mảng 1 chiều để lưu trữ 
//            string[] arrOut = new string[arr.GetLength(0)];

//            // Số lượng hàng 
//            for (int i = 0; i < arr.GetLength(0); i++)
//            {
//                string x = ""; // Đặt lại x cho mỗi hàng

//                // Số lượng cột 
//                for (int j = 0; j < arr.GetLength(1); j++)
//                {
//                    x += arr[i, j];
//                    if (j < arr.GetLength(1) - 1) // Thêm dấu phẩy nếu không phải phần tử cuối
//                    {
//                        x += ", ";
//                    }
//                }
//                arrOut[i] = x; // Gán chuỗi đã tạo cho arrOut
//            }

//            try
//            {
//                File.WriteAllLines(file, arrOut); // Ghi toàn bộ mảng vào tệp
//                Console.WriteLine($"Đã ghi mảng vào tệp CSV {file} thành công.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Đã xảy ra lỗi khi ghi vào tệp: {ex.Message}");
//            }
//        }
//        static List<Student> Read(string file)
//        {
//            List<Student> students = new List<Student>();

//            // Sử dụng using để tự động đóng StreamReader
//            using (StreamReader sr = new StreamReader(file))
//            {
//                while (!sr.EndOfStream)
//                {
//                    string line = sr.ReadLine();
//                    if (line.Trim() != "")
//                    {
//                        string[] fields = line.Split(',');
//                        if (fields.Length >= 4)
//                        {
//                            students.Add(new Student(int.Parse(fields[0]), fields[1])); // Đã sửa biến 'field' thành 'fields'
//                        }
//                    }
//                }
//            }

//            return students;
//        }
//        class Student
//        {
//            public int Id { get; set; }
//            public string Name { get; set; }

//            public Student(int id, string name)
//            {
//                Id = id;
//                Name = name;
//            }
//        }
//        static void Main(string[] args)
//        {
//            string filePath = "students.csv"; // Đường dẫn tới tệp CSV
//            List<Student> studentList = Read(filePath); // Đọc danh sách sinh viên

//            // Hiển thị danh sách sinh viên
//            foreach (var student in studentList)
//            {
//                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace CSharp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File luu tru 
            string path = "outCsv.csv";
            // Tao list anime 
            List<Animal> animal = new List<Animal>
            {
                new Animal {Name = "Capybara", Description = "bo doi"},
                new Animal {Name = "Dog", Description = "gau"},
                new Animal {Name = "Mouse",Description = "chit chit"},
                new Animal {Name = "Human",Description = "ghet loai nguoi"}
            };
            //write_text_all();
            //write_text_line();
            //write_text_by_streamWriter();
            //read_text_by_streamReader();
            //write_csv(path, animal);
            List<Animal> animals = read_csv(path);
            foreach (Animal a in animals)
            {
                Console.WriteLine(a.Name + "+" + a.Description);
            }
            //read_json();
        }
        //ghi đè
        static void write_text_all()
        {
            string content = "i can buy myself flowers!";
            File.WriteAllText("output.txt", content);
        }
        static void write_text_line()
        {
            string[] content = { "i can buy myself flowers!", "write my name in the sand" };
            File.WriteAllLines("output.txt", content);
        }
        //ghi vao sau
        static void write_text_by_streamWriter()
        {
            string path = "output.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("string");
                writer.WriteLine(42);
                writer.WriteLine(42.3f);
                writer.WriteLine(42.5m);
            }

        }
        static void read_text_all()
        {
            String content = File.ReadAllText("output.txt");
            Console.WriteLine(content);
        }
        static void read_text_line()
        {
            IEnumerable<string> lines = File.ReadLines("output.txt");
            //foreach (string line in lines)
            //{
            Console.WriteLine(lines.ElementAt(1));
            //}

        }
        static void read_text_by_streamReader()
        {
            using (StreamReader reader = new StreamReader("output.txt"))
            {

                Console.WriteLine(reader.ReadLine());
                Console.WriteLine(reader.ReadLine());
                //Console.WriteLine(reader.ReadToEnd());
                reader.Close();
            }
        }
        static void write_csv(string path, List<Animal> animal)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Name,Des");
                foreach (Animal a in animal)
                {
                    writer.WriteLine(a.Name + "," + a.Description);
                }
            }
        }
        static List<Animal> read_csv(string path)
        {
            List<Animal> animal = new List<Animal>();
            using (StreamReader reader = new StreamReader(path))
            {
                reader.ReadLine();
                String line = reader.ReadLine();
                while (line != null)
                {
                    String[] field = line.Split(',');
                    animal.Add(new Animal { Name = field[0], Description = field[1] });
                    line = reader.ReadLine();
                }
            }
            return animal;
            //foreach (Animal a in animal)
            //{
            //    Console.WriteLine(a.Name + "+" +a.Description);
            //}
        }
        static void write_json()
        {
            string path = "Json.json";
            List<Animal> animal = new List<Animal>
            {
                new Animal {Name = "Capybara", Description = "bo doi"},
                new Animal {Name = "Dog", Description = "gau"},
                new Animal {Name = "Mouse",Description = "chit chit"},
                new Animal {Name = "Human",Description = "ghet loai nguoi"}
            };
            string json = JsonSerializer.Serialize(animal, new JsonSerializerOptions { WriteIndented = true });
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(json);
            }
        }
        static List<Animal> read_json(string path)
        {
            List<Animal> animal = new List<Animal>();

            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                animal = JsonSerializer.Deserialize<List<Animal>>(json);
            }
            return animal;
            //foreach(Animal a in animal)
            //{
            //    Console.WriteLine($"{a.Name}, {a.Description}");
            //}
        }
    }
    internal class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public Animal() { }
    }
}