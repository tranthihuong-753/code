namespace DBfirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DBfirst.tuTucLaHanhPhucclass23IT4test.BloggingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "DBfirst.tuTucLaHanhPhucclass23IT4test";
        }

        protected override void Seed(DBfirst.tuTucLaHanhPhucclass23IT4test.BloggingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
