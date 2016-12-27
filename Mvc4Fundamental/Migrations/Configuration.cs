using Mvc4Fundamental.Models;

namespace Mvc4Fundamental.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc4Fundamental.DataAccessLayer.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Mvc4Fundamental.DataAccessLayer.DepartmentDb context)
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
            //context.Employees.AddOrUpdate( d => d.Name , 
            //    new Employee { Name = "Care"} ,
            //    new Employee { Name = "Ipsum"},
            //    new Employee { Name = "Lorem" , Department = new Department
            //    {
            //        Id = 1
            //    }

            //});
        }
    }
}
