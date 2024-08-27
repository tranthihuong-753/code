using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gLLT1.bai1
{
    internal class inputConsole
    {
        static void Main(string[] arrgs)
        {
            // Nhập vào họ tên, tuổi, diểm toán, điểm văn từ console 
            string name;
            int age;
            float mathScore;
            float literatureScore;

            Console.Write("Name :");
            name = Console.ReadLine();
            Console.Write("age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Math score = ");
            mathScore = float.Parse(Console.ReadLine());
            Console.Write("Literature score = ");
            literatureScore = float.Parse(Console.ReadLine());

            Console.WriteLine("Em " + name + " , tuoi {0}, diem toan {1}, diem van {2}", age, mathScore, literatureScore);

            Console.ReadKey();
        }
    }
}
