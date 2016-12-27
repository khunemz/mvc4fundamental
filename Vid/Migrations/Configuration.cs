using Vid.Models;

namespace Vid.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Vid.Models.VideoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Vid.Models.VideoDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Videos.AddOrUpdate( v => v.Title , 
            //    new Video { Title = "MVC 4" , Length = 1000},
            //    new Video {Title = "I Fuck" , Length = 200},
            //    new Video { Title = "MVC 55454" , Length = 100},
            //    new Video {Title = "I Deep Fuck" , Length = 100}
            //    );
            //context.SaveChanges();
        }
    }
}
