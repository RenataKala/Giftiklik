using BusinessLayer.Interfaces;
using BusinessLayer.Repository;
using DataLayer.AspNetIdentity;
using GiftiKlik.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(GiftiKlik.Startup))]
namespace GiftiKlik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers(new RoleManagerRepository(), new UserManagerRepository());

        }
        private void createRolesandUsers(IRoleManager _roleManagerRepository, IUserManager _userManagerRepository)
        {

            // In Startup iam creating first Admin Role and creating a default Admin User    
            if (!_roleManagerRepository.RoleExists("Admin"))
            {

                // first we create Admin rool   
                var role = new IdentityRole();
                role.Name = "Admin";
                _roleManagerRepository.CreateRole(role);

                //Here we create a Admin super user who will maintain the website                  

                var user = new ApplicationUser();
                user.UserName = "renata.tanusheva@gmail.com";
                user.Email = "renata.tanusheva@gmail.com";

                string userPWD = "123456";

                var chkUser = _userManagerRepository.CreateUser(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = _userManagerRepository.AddToRole(user.Id, "Admin");

                }
            }

            // creating Creating Manager role    
            //if (!_roleManagerRepository.RoleExists("Manager"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Manager";
            //    _roleManagerRepository.CreateRole(role);

            //}

            // creating Creating User role    
            if (!_roleManagerRepository.RoleExists("User"))
            {
                var role = new IdentityRole();
                role.Name = "User";
                _roleManagerRepository.CreateRole(role);
            }
        }


    }
}