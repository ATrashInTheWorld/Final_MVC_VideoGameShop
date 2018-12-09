using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using VideoGameShop2.Models;
using Microsoft.AspNet.Identity;
using System.Data.Entity.Migrations;
using System.Linq;
[assembly: OwinStartupAttribute(typeof(VideoGameShop2.Startup))]
namespace VideoGameShop2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ///MINE
            CreateRolesandUsers();
        }

        //MINE
        private void CreateRolesandUsers()
        {
            ApplicationDbContext ctx = new ApplicationDbContext();

            /////// BASIC users
            ctx.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "users" });
            if (!ctx.Users.Any(u => u.UserName == "bog"))
            {
                var creator = new ApplicationUserManager(new UserStore<ApplicationUser>(ctx));
                var bog = new ApplicationUser { UserName = "bog", Email = "bog@vgs2.com" };
                creator.Create(bog, "myNameIsBogdan");
                creator.AddToRole(bog.Id, "users");
                ctx.Users.AddOrUpdate(bog);
            }
            if (!ctx.Users.Any(u => u.UserName == "bog2"))
            {
                var creator = new ApplicationUserManager(new UserStore<ApplicationUser>(ctx));
                var bog = new ApplicationUser { UserName = "bog2", Email = "bog2@vgs2.com" };
                creator.Create(bog, "myNameIsBogdan2");
                creator.AddToRole(bog.Id, "users");
                ctx.Users.AddOrUpdate(bog);
            }

            // EMPLOYEES
            ctx.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "employees" });
            if (!ctx.Users.Any(u => u.UserName == "emp"))
            {
                var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(ctx));
                var emp = new ApplicationUser { UserName = "emp", Email = "emp@evgs.com" };
                manager.Create(emp, "employee1");
                manager.AddToRole(emp.Id, "employees");
                ctx.Users.AddOrUpdate(emp);
            }
            if (!ctx.Users.Any(u => u.UserName == "emp2"))
            {
                var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(ctx));
                var emp = new ApplicationUser { UserName = "emp2", Email = "emp2@evgs.com" };
                manager.Create(emp, "employee2");
                manager.AddToRole(emp.Id, "employees");
                ctx.Users.AddOrUpdate(emp);
            }

            //ADMIN
            ctx.Roles.AddOrUpdate(r => r.Name, new IdentityRole { Name = "adomin" });
            if (!ctx.Users.Any(u => u.UserName == "adomin"))
            {
                var manager = new ApplicationUserManager(new UserStore<ApplicationUser>(ctx));
                var admin = new ApplicationUser { UserName = "adomin", Email = "admin@evgs.com" };
                // really secure I know
                manager.Create(admin, "adomin");
                manager.AddToRole(admin.Id, "adomin");
                ctx.Users.AddOrUpdate(admin);

            }
        }
    }
}
