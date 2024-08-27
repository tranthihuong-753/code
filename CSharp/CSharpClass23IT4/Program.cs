using Amazon.Runtime.CredentialManagement.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XAct;
using XAct.Collections;
using static CSharpClass23IT4.file;
using static CSharpClass23IT4.Program;
/*
namespace ns1
{
    class dog 
    {
        public string food()
        {
            return " an cut y";
        }
    }
}
namespace ns2
{
    class dog
    {
        public string food()
        {
            return " an cut y";
        }
    }
}
*/

namespace CSharpClass23IT4
{
    internal class Program
    {
        static void vidu1()
        {
            Console.WriteLine("xin chao IT4");
        }
        static void vidu2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void vidu3()
        {
            int a = 200;
            Console.WriteLine(a);
            const int b = 100;
            Console.WriteLine(b);
        }
        static void vidu4()
        {
            string s1 = "a string";
            string s2 = s1;
            Console.WriteLine("s1 is " + s1);
            Console.WriteLine("s2 is " + s2);
            s1 = "another string";
            Console.WriteLine("s1 is now " + s1);
            Console.WriteLine("s2 is now " + s2);
        }
        static void vidu5()
        {
            int x = Console.Read();
            Console.WriteLine((char)x);
            Console.ReadLine();
            string s = Console.ReadLine();
            Console.WriteLine(s);
            int i = 10;
            int j = 20;
            Console.WriteLine("{0} plus {1} equals {2}", i, j, i + j);
        }

        //static void vidu6()
        //{
        //    // Lệnh if
        //    int i1 = 1; // Hoặc giá trị khác
        //    bool isZero;
        //    if (i1 == 0)
        //    {
        //        isZero = true;
        //        Console.WriteLine("i1 is Zero");
        //    }
        //    else
        //    {
        //        isZero = false;
        //        Console.WriteLine("i1 is Non-zero");
        //    }
        //}
        static void vidu7()
        {
            string tenSV = Console.ReadLine();
            if (tenSV == "trang")
                Console.WriteLine("do la ban nu");
            else if (tenSV == "dung")
                Console.WriteLine("do la ban nam");
            else
                Console.WriteLine("chua ro");
        }

        static void vd8()
        {
            for (int i = 0; i < 100; i += 10)
            {
                for (int j = i; j < i + 10; j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        //while 
        static void vd9()
        {
            int i = 0;
            while (i < 100)
                ++i;
            Console.WriteLine("i: " + i);
            Console.ReadKey();
        }
        //do while 
        static void vd10()
        {
            int i = 0;
            do
            {
                ++i;
            } while (i < 100);
            Console.WriteLine("i: " + i);
            Console.ReadKey();
        }
        //foreach 
        static void vd11()
        {
            int[] arrayOflnts = { 1, 2, 3 };
            foreach (int temp in arrayOflnts)
                //temp++;
                Console.WriteLine(temp);
        }
        //array
        static void vd12()
        {
            string[] ar = { "L", "M", "V", "K" };
            Array.Sort(ar);
            Console.WriteLine("Sau khi xap xep : ");
            foreach (string a in ar)
                Console.WriteLine(a);
            Array.Reverse(ar);
            Console.WriteLine("Sau khi dao nguoc : ");
            foreach (string a in ar)
                Console.WriteLine(a);
            Console.ReadKey();
        }
        //Tinh n! 
        static void vd13()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                x *= i;
            }
            Console.WriteLine("n! = " + x);
            Console.ReadKey();
        }
        static void vd13b()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            for (int i = n; i > 1; i--)
            {
                x *= i;
            }
            Console.WriteLine("n! = " + x);
            Console.ReadKey();
        }
        // array 2 chieu
        static void vidu14()
        {
            int[,] myRectArray = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(myRectArray[i, j] + ",");
                }
                Console.WriteLine();
            }
            string[,] beatlename = new string[,] { { "lennon", "john" }, { "McCartney", "Paul" }, { "Harrison", "george" }, { "Starkey", "Richard" } };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(beatlename[i, j] + ",");
                }
                Console.WriteLine();
            }
            double[,] matrix = new double[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = 4;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matrix[i, j] + ",");
                }
                Console.WriteLine();
            }
        }
        // array khong deu  
        static void vd15()
        {
            int[][] arrJagged = new int[2][];
            arrJagged[0] = new int[] { 1, 2, 3 };
            arrJagged[1] = new int[] { 1, 2, 3, 4, 5 };
            //In ra 
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < arrJagged[i].Length; j++)
                {
                    Console.Write("     " + arrJagged[i][j]);
                }
                Console.WriteLine();
            }
        }
        // nhap vao mang array khong deu
        static void vd15b()
        {
            // Nhập vào chiều thứ nhất 
            Console.Write("Chiều thứ nhất của mảng Jagged là: ");
            int chieu1 = int.Parse(Console.ReadLine());
            // Tạo mảng Jagged 
            int[][] arrJagged = new int[chieu1][];
            // Nhập vào chiều thứ hai , lưu tạm vào mảng
            Console.Write("Chiều thứ hai của mảng Jagged lần lượt là: \n");
            int[] chieu2 = new int[chieu1];
            for (int i = 0; i < chieu1; i++)
            {
                chieu2[i] = int.Parse(Console.ReadLine());
            }
            // Tạo (khai báo) số lượng phần tử của mỗi mảng cho chiều 2 
            for (int i = 0; i < chieu1; i++)
            {
                arrJagged[i] = new int[chieu2[i]];
            }
            //Nhập vào phần tử của mảng
            Console.Write("Nhập vào phần tử của mảng: \n\n");
            for (int i = 0; i < chieu1; i++)
            {
                for (int j = 0; j < chieu2[i]; j++)
                {
                    // Mỗi arr[j][i] với i thay đổi thì nhận biết bằng cách xuống dòng 
                    arrJagged[i][j] = int.Parse(Console.ReadLine());
                }
                // Mỗi arr[j][i] với j thay đổi thì nhận biết bằn cách có 1 dòng trống 
                Console.WriteLine();
            }
            //In ra 
            for (int i = 0; i < chieu1; i++)
            {
                for (int j = 0; j < chieu2[i]; j++)
                {
                    Console.Write("     " + arrJagged[i][j]);
                }
                Console.WriteLine();
            }
        }
        // enum 
        enum GiaToc
        {
            Thu = 0, Di = 1, Gau = 2, CPU = 3
        }
        static void HaySuDungGiaToc(GiaToc x, int y)
        {
            switch (x)
            {
                case GiaToc.Thu:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Xanh la");
                    //Console.ResetColor;
                    break;
                case GiaToc.Di:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Vang chanh vang ta");
                    //Console.ResetColor;
                    break;
                case GiaToc.Gau:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Bien va gio, noi do khong co chung toi");
                    //Console.ResetColor;
                    break;
                case GiaToc.CPU:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Co do");
                    //Console.ResetColor;
                    break;
            }
        }
        static void vd17a()
        {
            GiaToc x = new GiaToc();
            HaySuDungGiaToc(x, 1);
        }
        public enum TimeOfDay
        {
            Morning = 0, Afternoon = 1, Evening = 2 // Co the thay the la Morning, Afternoon, Evening 
        }
        /*
         "Morning = 0, Afternoon = 1, Evening = 2" co ung dung hon so voi "Morning, Afternoon, Evening "
        Trong main : 
        vd17(TimeOfDay.Morning); TUONG DUONG VOI vd17((TimeOfDay)0); -> Cho nguoi dung nhap vao index 
         */
        static void vd17(TimeOfDay tod)
        {
            switch (tod)
            {
                case TimeOfDay.Morning:
                    Console.WriteLine("Good Morning!");
                    break;
                case TimeOfDay.Afternoon:
                    Console.WriteLine("Good Afternoon!");
                    break;
                case TimeOfDay.Evening:
                    Console.WriteLine("Good Evening!");
                    break;
                default:
                    Console.WriteLine("HELLO!");
                    break;
            }
        }
        //Exception chia cho 0 
        static void vd18(dynamic a, dynamic b)
        {
            double y = 0;
            try
            {
                y = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(" !@@! Exception: {0}", e);
            }
            finally
            {
                Console.WriteLine("Ket qua: {0}", y);
            }
        }
        // Exception lấy phần tử không có trong bảng 
        static void vd19()
        {
            int[] arr = new int[7];
            try
            {
                int x = arr[7];
            }
            catch (Exception e)
            {
                Console.WriteLine(" !@@! Exception: {0}", e);
            }
            finally
            {
                Console.WriteLine("Dung try khong bi loi.");
            }
        }
        // lớp MyException kế thừa từ lớp ApplicationException.
        // là một lớp dùng để biểu diễn các lỗi ứng dụng do người dùng định nghĩa
        class MyException : ApplicationException
        {
            // Hàm tạo của lớp MyException
            public MyException(string message)
                : base(message)
            {
            }
        }

        class Temperature
        {
            public int temperature = 0;
            public void showTemp()
            {
                if (temperature == 0)
                {
                    throw (new MyException("Muc nhiet do 0!"));
                }
                else
                {
                    Console.WriteLine("Nhiet do: {0}", temperature);
                }
            }
        }
        static void vd20()
        {
            Temperature temp = new Temperature();
            temp.temperature = 1;
            try
            {
                temp.showTemp();
            }
            catch (MyException e)
            {
                Console.WriteLine("Loi: {0}", e.Message);
            }
        }
        static void vd20_Exception3()
        {
            Temperature temp = new Temperature();
            temp.temperature = 1;
            try
            {
                temp.showTemp();
            }
            catch (MyException e)
            {
                Console.WriteLine("Loi: {0}", e.Message);
            }
        }
        // Ke thua 
        class Person
        {
            protected static string Name;
            protected static string ID;
            public Person(string a, string b)
            {
                Name = a;
                ID = b;
            }
            public void show()
            {
                //Console.WriteLine("Name: " + name);
                //Console.WriteLine("ID: " + ID);
                Console.WriteLine($"Name: {Name} \nID: {ID}");
            }
        }
        class Student : Person
        {
            private static string tenKhoa;
            private static string tenLop;
            public Student(string name, string id, string tk, string tl) : base(name, id)
            {
                tenKhoa = tk;
                tenLop = tl;
            }
            //In ra tenLop 
            public void showAll(int x)
            {
                Console.WriteLine("Ten khoa : {0}", tenKhoa);
            }
            // In ra full
            public void showAll()
            {
                //base.show();
                Console.WriteLine($"tenKhoa: {tenKhoa}\ntenLop : {tenLop}");
            }
            public void setInfo(string a)
            {
                tenKhoa = a;
            }
            public void setInfo(string a, string b)
            {
                tenKhoa = a;
                tenLop = b;
            }
        }
        // Phuong thuc nap chong la chi 2 ham cung ten khac bien 
        // Xem trong class Student ke thua tu lop Person 2 ham showAll() va showAll(int a)
        class Float
        {
            public float sum(float x, float y)
            {
                return x + y;
            }
            public float sum(float x, float y, float z)
            {
                return x + y + z;
            }
            public float sum(float[] arr, float x)
            {
                float sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                sum += x;
                return sum;
            }
        }
        static void vd21()
        {
            Float f = new Float();
            Console.WriteLine(f.sum(1, 3));
            Console.WriteLine(f.sum(1, 2, 3));
            float[] arr = new float[] { 4, 8 };
            Console.WriteLine(f.sum(arr, 7));
        }
        //Ke thua (không có đa kế thừa nhưng hỗ trợ tựa đa kế thừa virtual - override)
        class animal
        {
            string name;
            int age;
            string sex;
            public animal(string na, int ag, string se)
            {
                this.name = na;
                this.age = ag;
                this.sex = se;
            }
            public void fly()
            {
                Console.WriteLine("UM THI BIET BAY");
            }
            // virtual .... override 
            public virtual string food() {
                return "an duoc ngu duoc la tien";
            }
        }
        class dog : animal
        {
            string home;
            // Ham tao phai public 
            public dog(string na, int ag, string se, string ho) : base(na, ag, se)
            {
                this.home = ho;
            }
            public override string food()
            {
                return base.food() + " an cut y";
            }
        }
        void vd22()
        {
            dog cho = new dog("nguyen tri nhu ", 20, "nam", "dong anh ");
            Console.WriteLine(cho.food());
        }
        class a
        {
            private string foreName;
            public string ForeName
            {
                get
                {
                    return ForeName;
                }
                set
                {
                    if (value.Length > 20)
                    {
                        throw new Exception("Dai qua 20");
                    }
                    else
                    {
                        foreName = value;
                    }
                }
            }
        }
        static void vd23()
        {
            a ob = new a();
            ob.ForeName = "tran thi huongjfhhfwheoifhildnfhdalkhfiwelyoifhalhfilsdhaigfyweiohgeklshaglkhwsiofhioweyfoiwe";
            Console.WriteLine(ob.ForeName);
        }
        // interface - chi dinh nghix phuong thuc 
        interface IAnimal
        {
            // PT interface khong co body 
            void Say();
            Boolean Haha();
            Boolean Sleep();
        }
        // Them public vao cac PT interface ke thua thi khong loi 
        class Pig : IAnimal
        {
            public void Say()
            {
                Console.WriteLine("The Pig says: oik oik");
            }
            public Boolean Haha()
            {
                return true;
            }
            public Boolean Sleep()
            {
                return false;
            }
        }
        class Dog : IAnimal
        {
            public void Say()
            {
                Console.WriteLine("The Dog says go go");
            }
            public Boolean Haha()
            {
                return true;
            }
            public Boolean Sleep()
            {
                return false;
            }
        }
        static void vd30()
        {
            Pig p = new Pig();
            p.Say();
            Dog d = new Dog();
            d.Say();
            // Khi chay Start can cau lenh sau de ket qua console hien thi cho den khi nhap mot ky tu 
            Console.ReadKey();
        }
        //
        // string 
        static void vd31()
        {
            // Khai bao list 
            List<string> MyList = new List<string>();
            // Them phan tu vao list 
            MyList.Add("one");
            MyList.Add("two");
            //// Them phan tu vao list qua bang console cho den khi nhan enter
            //string a; 
            
            // In ra list 
            Console.WriteLine("List sau: ");
            Console.WriteLine("So luong phan tu trong list la: {0}", MyList.Count);
            foreach(string x in MyList)
            {
                Console.WriteLine("     " + x);
            }
            Console.WriteLine();
            // Kiem tra phan tu m co ton tai trong list khong
            string m = "ha ha";
            foreach(string x in MyList)
            {
                if (x.Equals(m))
                {
                    Console.WriteLine("Chuan nhe. Co trong list");
                }
            }
            //Chen 1 phan tu vao dau list
            MyList.Insert(0, "ha ha ha ha ha");
            // In ra list 
            Console.WriteLine("List ban dau: ");
            Console.WriteLine("So luong phan tu trong list la: {0}", MyList.Count);
            foreach (string x in MyList)
            {
                Console.WriteLine("     " + x);
            }
            Console.WriteLine();
        }
        // List int 
        static void vd32()
        {
            List<int> myListInt = new List<int>();
            myListInt.Add(1);
            myListInt.Add(2);
            myListInt.Add(3);
            myListInt.Add(4);

            // In ra mang
            Console.WriteLine("Mang ban dau : ");
            Console.WriteLine("So luong phan tu la : {0}", myListInt.Count);
            foreach(int x in myListInt)
            {
                Console.WriteLine("     " + x);
            }
            Console.WriteLine();
            // Them phan tu vao dau list
            myListInt.Insert(0, 0);
            // Kiem tra phan tu m co ton tai trong list khong 
            int m = 2;
            int index = 0;
            foreach(int x in myListInt)
            {
                if(x.Equals(m))
                {
                    Console.WriteLine("{0} ton tai trong mang tai index = {1}", m, index);
                }
                index++;
            }
            // In ra mang sau khi chinh sua
            Console.WriteLine("Mang sau: ");
            Console.WriteLine("So luong phan tu mang la: {0}", myListInt.Count);
            foreach(int x in myListInt)
            {
                Console.WriteLine("     " + x);
            }
            Console.WriteLine();
        }
        // Dinh nghĩa class ExampleList<Book> va ExampleList<Author>
        public class ExampleList<T>
        {
            List<T> listItem;
            public ExampleList()
            {
                listItem = new List<T>();
            }
            public void Add(T input)
            {
                listItem.Add(input);
            }
            public T GetVAlue(int index)
            {
                return listItem[index];
            }
            // Them ham count 
            public int count()
            {
                return listItem.Count;
            }
            // Ham in ra luon 
            public void print()
            {
                foreach(T x in listItem)
                {
                    Console.WriteLine("     " + x);
                }
            }
        }
        static void vd33()
        {
            // int? = int + null 
            ExampleList<int?> myListBoolean = new ExampleList<int?>();
            myListBoolean.Add(1);
            myListBoolean.Add(2);
            myListBoolean.Add(3);
            Console.WriteLine("Gia tri cua phan tu co index = 0 la {0}", myListBoolean.GetVAlue(0));
            // In ra list
            Console.WriteLine("Gia tri cua mang la: ");
            int i = 0;
            while(myListBoolean.GetVAlue(i) != null)
            {
                Console.WriteLine("     " + myListBoolean.GetVAlue(i));
                i++;
            }
        }
        class Book
        {
            public string Name { get; set; }
            public int PAge { get; set; }
        }
        class Author
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        interface IBaseRepository<T>
        {
            List<T> GetAll();
            T Save(T item);
        }
        class BaseRepository<T> : IBaseRepository<T>
        {
            public List<T> GetAll()
            {
                return new List<T>();
            }
            public T Save (T item)
            {
                return item;
            }
        }
        static void vd34()
        {
            BaseRepository<Book> bookRe = new BaseRepository<Book> ();
            BaseRepository<Author> authorRe = new BaseRepository<Author> ();
            Book book = bookRe.Save (new Book {Name="book one", PAge = 100 });
            Author author = authorRe.Save(new Author { Name = "author one", Age = 340 });
            Console.WriteLine("Book: {0} - page: {1}", book.Name, book.PAge);
            Console.WriteLine("Name: {0} - age: {1}", author.Name, author.Age);
        }
        // Cac kieu du lieu connection
        // arraylist
        static void vd35()
        {
            ArrayList alist1 = new ArrayList();
            ArrayList alist2 = new ArrayList();

            alist1.Add("item 1");
            alist1.Add("item 2");
            alist1.Add("item 3");
            alist1.Add("item 4"); // item 1, item 2, item 3, item 4 
            alist1.Add(0);// item 1, item 2, item 3, item 4, 0 
            alist1.Add((decimal)1.01234567891011121314151617181920);
            foreach (var x in alist1)
            {
                Console.WriteLine("     " + x);
            }
            //alist2.Add("item arraylist 2"); 

            //alist1.AddRange(alist2);// item 1, item 2, item 3, item 4, item arraylist 2

            //alist1.Insert(2, "New item"); // item 1, item 2, New item, item 3, item 4, item arraylist 2

            //// In 
            //foreach (var x in alist1)
            //{
            //    Console.WriteLine("     " + x);
            //}

        }
        static void vd35a()
        {
            ArrayList al1 = new ArrayList();
            ArrayList al2 = new ArrayList();
            al1.Add("CSharp");
            al1.Add(1);

            al2.Add("");
        }
        // Dictionary - sort no order - O(1)
        static void vd36()
        {
            // Mac dinh cot dau nhu ID cua DIctionary, khong giong nhau 
            Dictionary<string, string> mydic = new Dictionary<string, string> ();
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
        // HashTable
        static void vd37()
        {
            Hashtable mydic = new Hashtable();
            mydic.Add("key1", "value1");
            mydic.Add("key2", "value1");

            Console.WriteLine(mydic["key1"]);

            foreach(DictionaryEntry item in mydic)
            {
                Console.WriteLine("key : {0} - Value: {1} ", item.Key, item.Value);
            }

            foreach(var key in mydic.Keys)
            {
                Console.WriteLine("key: {0}", key);
            }
        }
        //SortedList 
        static void vd37a()
        {
            SortedList mySL = new SortedList();
            mySL.Add("Thirst", "!");
            mySL.Add("Second", "World");
            mySL.Add("First", "Hello");

            Console.WriteLine("mySL");
            Console.WriteLine(" Count:     {0}", mySL.Count);
            Console.WriteLine(" Capacity:  {0}", mySL.Capacity);
            Console.WriteLine(" Keys and Values:");

            Console.WriteLine("\t-KEY-\t-VALUE-");
            for (int i = 0; i < mySL.Count; i++)
            {
                //Console.WriteLine("\t{0}:\t{1}", mySL.GetKey(i), mySL.GetByIndex(i));
                Console.WriteLine("\t{0}:\t{1}", mySL.GetKey(i), mySL[mySL.GetKey(i)]);
            }
        }
        //stack vao truoc ra sau .Push them, Pop xoa va tra ve gia tri
        static void vd38()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            Console.WriteLine("Ban dau");
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:     {0}", myStack.Count);
            Console.Write("\tValues:");
            foreach (Object obj in myStack)
            {
                Console.Write("     {0}", obj);
            }
            // Them 2 phan tu 
            Console.WriteLine("\nThem 2 phan tu vao dau stack");
            myStack.Push("P1");
            myStack.Push("P2");
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:     {0}", myStack.Count);
            Console.Write("\tValues:");
            foreach (Object obj in myStack)
            {
                Console.Write("     {0}", obj);
            }
            // xoa phan tu thu 2 trong stack
            Console.WriteLine("\nXoa phan tu thu 2 trong stack ."); // index = 2 (index : 1 - (n-1))
            string[] arr = new string[myStack.Count - 2];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (string)myStack.Pop();
                //Console.WriteLine(arr[i]);
            }
            myStack.Pop(); // Lay ra phan t muon xoa 
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                myStack.Push(arr[i]);
            }
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:     {0}", myStack.Count);
            Console.Write("\tValues:");
            foreach (Object obj in myStack)
            {
                Console.Write("     {0}", obj);
            }
        }
        static void vd38a()
        {
            Stack myStack = new Stack();
            myStack.Push("Oi. ");
            myStack.Push("Tien");
            myStack.Push("Tay");

            Console.WriteLine("Ban dau");
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:     {0}", myStack.Count);
            Console.Write("\tValues:");
            foreach (Object obj in myStack)
            {
                Console.Write("     {0}", obj);
            }
            // Them 4 phan tu 
            Console.WriteLine("\nThem 4 phan tu vao dau stack");
            myStack.Push("Roi");
            myStack.Push("Xa");
            myStack.Push("Ma");
            myStack.Push("Song");
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:     {0}", myStack.Count);
            Console.Write("\tValues:");
            foreach (Object obj in myStack)
            {
                Console.Write("     {0}", obj);
            }
            // xoa phan tu thu 2 trong stack
            Console.WriteLine("\nXoa phan tu thu 2 trong stack ."); // index = 2 (index : 1 - (n-1))
            string[] arr = new string[myStack.Count - 2];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (string)myStack.Pop();
                //Console.WriteLine(arr[i]);
            }
            myStack.Pop(); // Lay ra phan t muon xoa 
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                myStack.Push(arr[i]);
            }
            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:     {0}", myStack.Count);
            Console.Write("\tValues:");
            foreach (Object obj in myStack)
            {
                Console.Write("     {0}", obj);
            }
            
        }
        //Queue vao truoc ra truoc 
        static void vd39()
        {
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(1); // Them vao cuoi 
            qu.Enqueue(2);
            qu.Enqueue(3);
            Console.WriteLine("Queue bd :");
            foreach(int i in qu)
            {
                Console.Write("     " + i);
            }
            // Them 2 phan tu vao dau 
            int[] arr = new int[qu.Count];
            for(int i = 0; i < arr.Length; ++i)
            {
                // Lay ra cai o dau 
                arr[i] = qu.Dequeue();
                //Console.WriteLine(arr[i]);
            }
            qu.Enqueue(-2);
            qu.Enqueue(-1);
            for(int i = 0; i < arr.Length ; ++i)
            {
                qu.Enqueue(arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Queue sau khi them 2 phan tu :");
            foreach (int i in qu)
            {
                Console.Write("     " + i);
            }
            //Xoa phan tu thu 2 
            // Lau gia tri cua cac phan tu co index tu 0 den sphan tu ngay truoc phan tu muon xoa 
            int[] arr1 = new int[1];
            for (int i = 0; i < arr1.Length; ++i)
            {
                arr1[i] = qu.Dequeue();
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Gia tri phan tu thu 2 la " + qu.Dequeue());
            int[] arr2 = new int[qu.Count];
            for (int i = 0; i < arr2.Length; ++i)
            {
                arr2[i] = qu.Dequeue();
                Console.WriteLine(arr2[i]);
            }
            for (int i = 0; i < arr1.Length; ++i)
            {
                qu.Enqueue(arr1[i]);
            }
            for (int i = 0; i < arr2.Length; ++i)
            {
                qu.Enqueue(arr2[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Queue sau khi xoa phan tu thu 2 :");
            foreach (int i in qu)
            {
                Console.Write("     " + i);
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
    internal class file
    {
        //txt 
        //Ghi vao file txt 
        //File ghi 
        static void writetxt(string nameFile)
        {
            if (File.Exists(nameFile))
            {
                FileStream st = new FileStream(nameFile, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(st);
                sw.WriteLine("\nthem nua 1");
                sw.Close();
            }
            else
            {
                FileStream st = new FileStream(nameFile, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(st);
                sw.WriteLine("\nPApa");
                sw.Close();
            }
        }
        //Doc tu file txt 
        static void readtxtAll(string nameFile)
        {
            if (File.Exists(nameFile))
            {
                FileStream fs = new FileStream(nameFile, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
            else
            {
                Console.WriteLine("File {nameFile} no exists.");
            }
        }
        //csv 
        //Ghi vao file csv (kha giong ghi file .txt)
        static void writeCsv(string nameFile, List<Animal> data)
        {
            FileStream st = new FileStream(nameFile, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(st);
            foreach(Animal x in data)
            {
                sw.WriteLine($"{x.Name},{x.Age}");
            }
            sw.Close();
        }
        //Doc tu file csv (y chang doc file .txt)
        static void readCsv(string nameFile)
        {
            if (File.Exists(nameFile))
            {
                FileStream fs = new FileStream(nameFile, FileMode.OpenOrCreate, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
            else
            {
                Console.WriteLine($"File {nameFile} no exists.");
            }
        }
        static void vdcsv()
        {
            string name = "EmChangTheNguoiNgoai.csv";
            //writeCsv(name, animals);
            readCsv(name);
        }
        //json
        // Ghi vao file json 
        // Sau khi ghi phai close de giai phong tai nguyen , neu khong thi khong them vao duoc 
        static void writeJson(string nameFile, List<Animal> data)
        {
            // Chuyển đổi dictionary thành định dạng JSON
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }); // nếu lỗi thì chuyển qua dùng JsonConvert , phải tải newtonsort  
            Console.WriteLine("json = " + json);
            if (File.Exists(nameFile))
            //&& !string.IsNullOrEmpty(nameFile)
            {
                string exJson = File.ReadAllText(nameFile);
                if (!string.IsNullOrEmpty(exJson))
                {
                    exJson = exJson.Substring(0, exJson.Length - 3) + ",";
                    json = exJson + json.Substring(1);
                    File.WriteAllText(nameFile, json);
                    Console.WriteLine("Them du lieu vao file json thanh cong.");
                    return;
                }
                json = exJson + json.Substring(0);
                File.WriteAllText(nameFile, json);
                Console.WriteLine("Them du lieu vao file json thanh cong.");
                return;
            }
        }
        // Doc file json 
        static void readJson(string nameFile)
        {
            try
            {
                // Đọc nội dung file
                string jsonString = File.ReadAllText(nameFile);
                // In ra nội dung của file
                Console.WriteLine(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
        static void vdjson()
        {
            string name = "NuocMatRoiViNgayMai.json";
            //TroiBanBoChuDuyenThiDungNenBoLo
            writeJson(name, animals);
            readJson(name);
        }
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
        static List<Animal> animals = new List<Animal>
            {
                //new Animal { Name = "Capybara", Age = 1 },
                //new Animal { Name = "Dog", Age = 2.4 },
                //new Animal { Name = "HuongDuong", Age = 2.3 },
                //new Animal { Name = "Human", Age = 1.3 },
                new Animal { Name = "h", Age = 2 },
                new Animal { Name = "Huong", Age = 1.2 }
            };
        static void Main(string[] args)
        {
            vdjson();
        }
    }
    internal class connectDBOne
    {
        static string myLap2 = "Data Source = BuonBuonVuiVui ; Integrated Security = True";
        static string nameDB = "CSDLdemo";
        static string myLap3 = $"Data Source = BuonBuonVuiVui ; Database = {nameDB} ; Integrated Security = True";
        // Ham tao co so du lieu . Input : ten CSDL 
        static void createDB(string nameDB)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = myLap2;
            try
            {
                con.Open();
                string txtSQLcreate = $"create database {nameDB}";
                SqlCommand cmd = new SqlCommand(txtSQLcreate, con);//lưu trữ câu lệnh SQL cần thực thi cùng với kết nối đến cơ sở dữ liệu.(data + @dich + tim duong)
                cmd.ExecuteNonQuery(); // thực thi các lệnh SQL không trả về dữ liệu
                Console.WriteLine($"Tao moi Database {nameDB} thanh cong!");
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
        // Ham tao bang, tao ban ghi. Input : Cau lenh SQL 
        static void thaoTac(string txtSQLcreate)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = myLap3;
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
        // Ham lay ra ket qua tu cau truy van 
        static void thaoTacTraVe(string txtSql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = myLap3;
            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand(txtSql, con);
                SqlDataReader sdr = cm.ExecuteReader();
                // Lấy thông tin về các cột
                var columnNames = new List<string>();
                for (int i = 0; i < sdr.FieldCount; i++) // sdr.FieldCount = so luong cot trong KQ truy van
                { 
                    columnNames.Add(sdr.GetName(i)); // them ten cot tai index = i vao list 
                }
                Console.WriteLine(string.Join(" | ", columnNames));// In ra tên các cột

                // Đọc và in ra từng dòng dữ liệu
                // sdr.Read() di chuyen den ban ghi tiep theo . Neu co thi tra ve true, khong co thi tra ve false 
                while (sdr.Read())
                {
                    var rowValues = new List<string>(); // lưu trữ các giá trị của mỗi cột trong hàng hiện tại.
                    foreach (var columnName in columnNames)
                    {
                        rowValues.Add(sdr[columnName].ToString());
                    }
                    Console.WriteLine(string.Join(" | ", rowValues));
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
        static void vd1()
        {
            //createDB(nameDB);
            //string txtSqlcreate = "create table Category(\r\n\tIDCategory int identity(0, 1),\r\n\tNameCategory nvarchar(100) not null,\r\n\tStatus tinyint default 1 check(Status in(0, 1)) \r\n)";
            //thaoTac(txtSqlcreate);
            //string txtSqlinsert = "INSERT INTO Category (NameCategory, Status) VALUES \r\n    ('Electronics', 1),\r\n    ('Books', 1),\r\n    ('Clothing', 1),\r\n    ('Sports', 1),\r\n    ('Home & Kitchen', 1),\r\n    ('Toys & Games', 1),\r\n    ('Health & Personal Care', 1),\r\n    ('Automotive', 1),\r\n    ('Beauty', 1),\r\n    ('Garden & Outdoor', 1);";
            //thaoTac(txtSqlinsert);
            //string x = "create table Author(\r\n\tIDAuthor int identity(0, 1) primary key,\r\n\tNameAuthor nvarchar(100) not null,\r\n\tTotalBook int default 0\r\n)\r\nINSERT INTO Author (NameAuthor, TotalBook) VALUES \r\n    ('Jane Austen', 6),\r\n    ('Charles Dickens', 15),\r\n    ('Mark Twain', 12),\r\n    ('George Orwell', 9),\r\n    ('J.K. Rowling', 7),\r\n    ('Ernest Hemingway', 8),\r\n    ('F. Scott Fitzgerald', 5),\r\n    ('Virginia Woolf', 10),\r\n    ('Leo Tolstoy', 20),\r\n    ('Agatha Christie', 85),\r\n\t('hi hi ', 23)";
            //thaoTac(x);
            //string x1 = "create table book(\r\n\tIDBook int identity(0, 1) primary key,\r\n\tNameBook nvarchar(150) not null,\r\n\tStatus tinyint default 1 check(Status in(0, 1)),\r\n\tPrice float not null check(Price >= 100000),\r\n\tCreatedDateBook date default getdate(),\r\n\tIDCategory int not null,\r\n\tIDAuthor int not null,\r\n\tforeign key (IDCategory) references Category(IDCategory),\r\n\tforeign key (IDAuthor) references Author(IDAuthor)\r\n)\r\nINSERT INTO book (NameBook, Status, Price, CreatedDateBook, IDCategory, IDAuthor) VALUES \r\n    ('Pride and Prejudice', 1, 150000, DEFAULT, 2, 1),\r\n    ('Great Expectations', 1, 200000, DEFAULT, 2, 2),\r\n    ('Adventures of Huckleberry Finn', 1, 180000, DEFAULT, 2, 3),\r\n    ('1984', 1, 170000, DEFAULT, 2, 4),\r\n    ('Harry Potter and the Philosophers Stone', 1, 220000, DEFAULT, 2, 5),\r\n    ('The Old Man and the Sea', 1, 160000, DEFAULT, 2, 6),\r\n    ('The Great Gatsby', 1, 190000, DEFAULT, 2, 7),\r\n    ('To the Lighthouse', 1, 210000, DEFAULT, 2, 8),\r\n    ('War and Peace', 1, 250000, DEFAULT, 2, 9),\r\n    ('Murder on the Orient Express', 1, 250000, DEFAULT, 3, 0),\r\n\t('Life Of Pi', 1, 270000, DEFAULT, 3, 0),\r\n\t('The Godfather', 1, 390000, DEFAULT, 5, 0),\r\n\t('The Alchemist', 1, 260000, DEFAULT, 6, 0),\r\n\t('Harry Potter', 1, 260000, DEFAULT, 5, 0),\r\n\t('Diary Of A Wimpy Kid', 1, 490000, DEFAULT, 8, 0);\r\ncreate table Customer(\r\n\tIDCustomer int identity(0,1) primary key,\r\n\tNameCustomer nvarchar(150) not null,\r\n\tEmail varchar(150) not null unique check(Email like '%@gmail.com' or Email like '%@facebook.com' or Email like '%@bachkhoa-aptech.edu.vn'),\r\n\tPhone nvarchar(50) not null unique,\r\n\tAddress nvarchar(255),\r\n\t-- dùng \" check (CreatedDateCustomer >= getdate())\" thì ngày hôm nay lỗi , từ ngày mai mới được -> Chắc bị ngu \r\n\t-- dùng trigger nhưng chưa học -> Dùng tạm check, học rồi thì sửa \r\n\tCreatedDateCustomer date default getdate() check (CreatedDateCustomer >= getdate()),\r\n\tGender tinyint check(Gender in(0, 1, 2)),\r\n\tBirthday date not null\r\n)\r\nalter table Customer\r\nadd constraint check_CreatedDateCustomer check(CreatedDateCustomer >= getdate());\r\nINSERT INTO Customer (NameCustomer, Email, Phone, Address, CreatedDateCustomer, Gender, Birthday) VALUES\r\n('Alice', 'alice@gmail.com', '1234567890', '123 Main St','2024-12-12', 1, '1990-01-01'),\r\n('Bob', 'bob@facebook.com', '1234567891', '456 Elm St', '2024-06-24', 0, '1985-02-02'),\r\n('Charlie', 'charlie@bachkhoa-aptech.edu.vn', '1234567892', '789 Maple St', '2024-06-25', 1, '1992-03-03'),\r\n('David', 'david@gmail.com', '1234567893', '101 Oak St', '2024-06-27', 0, '1980-04-04'),\r\n('Eve', 'eve@facebook.com', '1234567894', '202 Pine St', '2024-06-28', 1, '1995-05-05'),\r\n('Frank', 'frank@bachkhoa-aptech.edu.vn', '1234567895', '303 Birch St', '2024-06-27', 2, '1993-06-06'),\r\n('Grace', 'grace@gmail.com', '1234567896', '404 Cedar St', '2024-06-30', 1, '1988-07-07'),\r\n('Hank', 'hank@facebook.com', '1234567897', '505 Walnut St', '2024-06-30', 0, '1991-08-08'),\r\n('Ivy', 'ivy@bachkhoa-aptech.edu.vn', '1234567898', '606 Chestnut St', '2024-06-28', 1, '1996-09-09'),\r\n('Jack', 'jack@gmail.com', '1234567899', '707 Aspen St', '2024-06-30', 2, '1990-10-10');\r\ncreate table Ticket(\r\n\tIDTicket int identity(0, 1) primary key,\r\n\tIDCustomer int not null,\r\n\tStatus tinyint default 1 check(Status in(0, 1, 2, 3)),\r\n\tTicketdate datetime default getdate(),\r\n\tforeign key  (IDCustomer) references Customer(IDCustomer)\r\n)\r\nINSERT INTO Ticket (IDCustomer, Status, Ticketdate) VALUES \r\n    (1, 1, DEFAULT),\r\n    (2, 2, DEFAULT),\r\n    (3, 3, DEFAULT),\r\n    (4, 1, DEFAULT),\r\n    (5, 2, DEFAULT),\r\n    (6, 3, DEFAULT),\r\n    (7, 1, DEFAULT),\r\n    (8, 2, DEFAULT);\r\ncreate table TicketDetail(\r\n\tIDTicket int not null,\r\n\tIDBook int not null,\r\n\tQuantity int not null check (Quantity > 0),\r\n\tDeposiPrice float not null,\r\n\tRentCost float not null,\r\n\tforeign key (IDTicket) references Ticket(IDTicket), \r\n\tforeign key (IDBook) references book(IDBook)\r\n)\r\nINSERT INTO TicketDetail (IDTicket, IDBook, Quantity, DeposiPrice, RentCost) VALUES \r\n    (16, 10, 2, 50000, 10000),\r\n    (9, 12, 1, 60000, 12000),\r\n    (13, 12, 3, 70000, 14000),\r\n    (14, 16, 2, 80000, 16000),\r\n    (15, 12, 1, 90000, 18000),\r\n    (16, 16, 4, 100000, 20000),\r\n    (10, 12, 2, 110000, 22000),\r\n    (10, 18, 1, 120000, 24000)";
            //thaoTac(x1);
            //string x2 = "select b.IDBook, b.NameBook, b.Status, b.CreatedDateBook, c.NameCategory, a.NameAuthor, b.Price\r\nfrom (book b inner join Category c on b.IDCategory = c.IDCategory) inner join Author a on b.IDAuthor = a.IDAuthor\r\norder by b.Price desc ";
            //thaoTacTraVe(x2);
        }
        static void Main(string[] args)
        {
            vd1();
        }
    }
    internal class entityFrameWork
    {
        // Ham truy suat thong tin 
        static void truyXuatThongTin(connectEntity db)
        {
            var query = from st in db.students where st.id == 101 select new { st.name, st.id };
            foreach (var item in query)
            {
                Console.WriteLine("ID: " + item.id + ", NAME: " + item.name);
            }
        }
        // Ham them ban ghi 
        static void themDuLieu(connectEntity db, int id, string name, string email, string join_data)
        {
            //Nullable<System.DateTime>
            student st1 = new student();
            st1.id = id;
            st1.name = name;
            st1.email = email;
            st1.join_data = DateTime.Now;
            var query = db.students.Add(st1);
            db.SaveChanges();
        }
        static void Main(string[] args)
        {
            connectEntity a = new connectEntity();
            //truyXuatThongTin(a);
            themDuLieu(a, 2, "cho", "cho1@gmail.com", "g");
        }
    }
}

