using CSharpTestMigration.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestMigration
{
    internal class Program
    {
        // tai entityframework 
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
        public class User
        {
            public int UserId { get; set; }
            public DateTime SignInDate { get; set; }
        }
        public class BloggingContext : DbContext
        {
            public BloggingContext() : base("name=TestMigration_connectionString")
            {
            }

            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<User> Users { get; set; }

        }
        public static void CreateDabase()
        {
            var context = new BloggingContext();
            context.Database.Initialize(true);
        }
        static void Main(string[] args)
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BloggingContext,
            Configuration>());
            CreateDabase();
            Console.WriteLine("Tao CSDL thanh cong!");
            Console.ReadLine();
        }
    }
}
