namespace App.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<App.Models.DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(App.Models.DbContext context)
        {
            //context.Users.AddOrUpdate(u => u.Id,
            //    new App.Models.User
            //    {
            //        Id = 1,
            //        Name = "Tester",
            //        Email = "Tester@test.com",
            //        Password = "tester"
            //    }
            //);

            //context.SaveChanges();
        }
    }
}
