using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OITJP2016.Models;

[assembly: OwinStartupAttribute(typeof(OITJP2016.Startup))]
namespace OITJP2016
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //CreateRolesandUsers();
        }

        /***************************************************************************************
        *
        * Borrowed code from: https://code.msdn.microsoft.com/ASPNET-MVC-5-Security-And-44cbdb97
        * 
        * **************************************************************************************/
        // In this method we will create default User roles and Admin user for login   
        //private void CreateRolesandUsers()
        //{
        //    ApplicationDbContext context = new ApplicationDbContext();

        //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        //    var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


        //    // In Startup I am creating first Admin Role and creating a default Admin User    
        //    if (!roleManager.RoleExists("Admin"))
        //    {

        //        // first we create Admin role   
        //        var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //        role.Name = "Admin";
        //        roleManager.Create(role);

        //        //Here we create an Admin super user who will maintain the website                  

        //        //var user = new ApplicationUser();
        //        //user.UserName = "shanu";
        //        //user.Email = "syedshanumcain@gmail.com";

        //        //string userPWD = "A@Z200711";

        //        //var chkUser = UserManager.Create(user, userPWD);

        //        ////Add default User to Role Admin   
        //        //if (chkUser.Succeeded)
        //        //{
        //        //    var result1 = UserManager.AddToRole(user.Id, "Admin");

        //        //}
        //    }

        //    // creating Creating Manager role    
        //    if (!roleManager.RoleExists("Contributor"))
        //    {
        //        var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //        role.Name = "Contributor";
        //        roleManager.Create(role);

        //    }

        //    // creating Creating Employee role    
        //    if (!roleManager.RoleExists("User"))
        //    {
        //        var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //        role.Name = "User";
        //        roleManager.Create(role);

        //    }
        //}
    }
}
