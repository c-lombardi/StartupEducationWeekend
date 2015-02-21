namespace StartupEducationWeekend.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;
    using System.Web.Security;
    using WebMatrix.WebData;
    using StartupEducationWeekend.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<StartupEducationWeekend.Models.StartUpEducationWeekendContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StartupEducationWeekend.Models.StartUpEducationWeekendContext context)
        {
            if (!WebSecurity.Initialized)
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);
            if (!Roles.RoleExists("Administrator"))
                Roles.CreateRole("Administrator");
            if (!Roles.RoleExists("User"))
                Roles.CreateRole("User");
            if (!Roles.RoleExists("UnAuthenticated"))
                Roles.CreateRole("UnAuthenticated");
            string[] adminArr = new string[1];
            adminArr[0] = "Administrator";
            if (!WebSecurity.UserExists("admin@pitt.edu"))
                WebSecurity.CreateUserAndAccount(
                    "admin@pitt.edu",
                    "password");
            Roles.AddUserToRoles("admin@pitt.edu", adminArr);

            context.Colleges.AddOrUpdate(new Colleges()
            {
                CollegeName = "University Of Pittsburgh",
                CollegeId = "pitt.edu"
            });
            context.Colleges.AddOrUpdate(new Colleges()
            {
                CollegeName = "Grove City College",
                CollegeId = "gcc.edu"
            });
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
        }
    }
}
