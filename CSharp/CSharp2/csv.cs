using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace CSharp2
{
    internal class animal
    {
        public string name;
        public string age;
    }
    internal class csv
    {
        // Ham ghi csv 
        static void writeCSV(string file, List<animal> ani)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine("Name,Des");
                foreach (animal a in ani)
                {
                    writer.WriteLine(a.name + "," + a.age);
                }
            }
        }
        // Ham doc csv 
        static List<animal> readCSV(string list)
        {
            List<animal> animal = new List<animal>();
            using (StreamReader reader = new StreamReader(list))
            {
                reader.ReadLine();
                String line = reader.ReadLine();
                while (line != null)
                {
                    String[] field = line.Split(',');
                    animal.Add(new animal { name = field[0], age = field[1] });
                    line = reader.ReadLine();
                }
            }
            return animal;
        }
        // Tao va tra ve list 
        static List<animal> listani()
        {
            List<animal> animal = new List<animal>
            {
                new animal {name = "Capybara", age = "1"},
                new animal {name = "Dog", age = "2.4"},
                new animal {name = "Mouse",age = "2.3"},
                new animal {name = "Human",age = "1.3"}
            };
            //Console.WriteLine(animal[1].name);
            return animal;
        }
        // Ham ghi json
        static void write_json(string path)
        {
            List<animal> animals = listani();
            //Console.WriteLine(animals[1].name);
            // Chuyển đổi danh sách thành JSON
            string json = JsonSerializer.Serialize(animals, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(json);
            // Ghi vào tệp JSON
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(json); // Ghi json thay vì path
            }
        }
        // Ham doc json 
        static List<animal> read_json(string path)
        {
            List<animal> animal = new List<animal>();

            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                animal = JsonSerializer.Deserialize<List<animal>>(json);
            }
            return animal;
        }
        static void Main(string[] args)
        {
            //string path = "outCsv.csv";
            //List<Animal> animals = read_csv(path);
            //foreach (Animal a in animals)
            //{
            //    Console.WriteLine(a.Name + "+" + a.Description);
            //}
            string path = "outJson.json";
            write_json(path);
            //read_json(path);
        }      
    }
}
