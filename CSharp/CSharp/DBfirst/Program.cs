using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBfirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            connectEntity db = new connectEntity();
            truyXuatThongTin(db);
        }
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
        
    }
    internal class tuTucLaHanhPhucclass23IT4
    {
        // Định nghĩa lớp Person 
        public class Person
        {
            public int PersonId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        // Tao lớp ngữ cảnh (context class) kế thừa từ lớp DbContext.
        // Sử dụng để tương tác với cơ sở dữ liệu bằng cách định nghĩa các tập hợp thực thể (DbSet) mà bạn muốn làm việc.
        public class Context : DbContext
        {
            public Context() : base("name=CodeFirst_connectionString")
            {
            }
            public DbSet<Person> People { get; set; }
        }
        static void vd1_CreateDB()
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();
            }
        }
        static void vd2_Insert(string fname, string lname)
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();
                var person = new Person
                {
                    FirstName = fname,
                    LastName = lname
                };
                context.People.Add(person);
                context.SaveChanges();
                Console.WriteLine("Insert successfull");
                Console.ReadKey();
            }
        }
        private static void vd3_Query()
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();
                Retrieve(context);
                Console.WriteLine("Query successfull");
            }
            Console.ReadKey();
        }
        //Lấy dữ liệu từ cơ sở dữ liệu thông qua đối tượng ngữ cảnh Context
        private static void Retrieve(Context context)
        {
            var people = context.People;
            foreach (var person in people)
            {
                Console.WriteLine($"[{person.PersonId}] {person.FirstName} { person.LastName} "); 
            }
        }
        private static void vd4_Update()
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();
                Console.WriteLine("Before:");
                Retrieve(context);
                Update(context);
                Console.WriteLine("After:");
                Retrieve(context);
                Console.WriteLine("Update successfull");
            }
            Console.ReadKey();
        }
        private static void Update(Context context)
        {
            // Thuc the dau tien 
            //var person = context.People.FirstOrDefault();
            var person = context.People.SingleOrDefault(p => p.FirstName == "Tran");
            if (person != null)
            {
                
                person.FirstName = "Barrack";
                person.LastName = "Obama";
                context.SaveChanges();
            }
        }
        private static void vd5_Delete()
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();
                Delete(context);
                Console.WriteLine("Delete successfull");
            }
            Console.ReadKey();
        }
        private static void Delete(Context context)
        {
            var person = context.People.FirstOrDefault();
            if (person != null)
            {
                context.People.Remove(person);
                context.SaveChanges();
            }
        }
        public class CompanyContext : DbContext
        {
            public CompanyContext() : base("name=hehehe")
            {
            }
            public DbSet<Author> Authors { get; set; }
            public DbSet<Article> Articles { get; set; }
            public DbSet<Payroll> Payrolls { get; set; }
        }
        public class Author
        {
            [Key]
            public int AuthorId { get; set; }

            [StringLength(100)]
            public string Name { get; set; }
            // Them thuoc tinh tuoi 
            public int age {  get; set; }
            public ICollection<Article> Articles { get; set; }
        }
        public class Article
        {
            [Key]
            public int ArticleId { get; set; }
            public string Name { get; set; }

            //[ForeignKey(nameof(AuthorId))] 
            public int AuthorId { get; set; }
            public Author Author { get; set; }
        }
        public class Payroll
        {
            [Key]
            public int PayrollId { get; set; }

            //[ForeignKey(nameof(AuthorId))] 
            public int AuthorId { get; set; }
            public int Salary { get; set; }
            public Author Author { get; set; }
        }
        static void vd1()
        {
            using (var db = new CompanyContext())
            {
                db.Database.CreateIfNotExists();
                var author = new Author { Name = "Nguyễn Văn An" };
                var article = new Article { Name = "Kỹ thuật lập trình" };
                article.AuthorId = author.AuthorId;
                db.Authors.Add(author);
                db.Articles.Add(article);
                db.SaveChanges();
                var au = article.Author;
                Console.WriteLine("Author: " + au.AuthorId + " - " + au.Name);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //vd1_CreateDB();
            //vd2_Insert("Huong", "Tran");
            //vd3_Query();
            //vd4_Update();
            vd1();
        }
    }
    internal class tuTucLaHanhPhucclass23IT4test
    {
        public class Blog
        {
            public int BlogId { get; set; }
            public string Name { get; set; }

            public virtual List<Post> Posts { get; set; }
        }
        public class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            //public string Note { get; set; }

            public int BlogId { get; set; }
            public virtual Blog Blog { get; set; }
        }
        public class BloggingContext : DbContext
        {
            public BloggingContext() : base("name=TestMigration_connectionString")
            {
            }

            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
        }
        public static void CreateDabase()
        {
            var context = new BloggingContext();
            context.Database.Initialize(true);
        }
        static void Main(String[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BloggingContext, Configuration>());
            CreateDabase();
            Console.WriteLine("Tao CSDL thanh cong!");
            Console.ReadLine();
        }

    }
    //internal class TestMigration
    //{
    //    // Ding nghia class Blog 
    //    public class Blog
    //    {
    //        public int BlogId { get; set; }
    //        public string Name { get; set; }
    //        public virtual List<Post> Posts { get; set; }
    //    }
    //    // Dinh nghia class Post 
    //    public class Post
    //    {
    //        public int PostId { get; set; }
    //        public string Title { get; set; }
    //        public string Content { get; set; }
    //        public string Note { get; set; }
    //        public int BlogId { get; set; }
    //        public virtual Blog Blog { get; set; }
    //    }
    //    // Tao context TestMigration_connectionString
    //    public class BloggingContext : DbContext
    //    {
    //        public BloggingContext() : base("name=TestMigration_connectionString")
    //        {
    //        }

    //        public DbSet<Blog> Blogs { get; set; }
    //        public DbSet<Post> Posts { get; set; }
    //    }
    //    public static void CreateDabase()
    //    {
    //        var context = new BloggingContext(); // đại diện cho kết nối đến cơ sở dữ liệu 
    //        context.Database.Initialize(true);
    //    }
    //    static void Main(string[] args)
    //    {
    //        Database.SetInitializer(new MigrateDatabaseToLatestVersion<BloggingContext, Configuration>());
    //        CreateDabase();
    //        Console.WriteLine("Tao CSDL thanh cong!");
    //        Console.ReadLine();
    //    }
    //}
}