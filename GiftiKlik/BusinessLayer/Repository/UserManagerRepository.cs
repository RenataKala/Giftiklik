using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.AspNetIdentity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository
{
    public class UserManagerRepository : IUserManager
    {
        private ApplicationDbContext context;
        private UserManager<ApplicationUser> userManager;
        public UserManagerRepository()
        {
            context = new ApplicationDbContext();
            userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
        }
        public IdentityResult CreateUser(ApplicationUser user, string password)
        {
            return userManager.Create(user, password);
        }
        public IdentityResult AddToRole(string userId, string roleName)
        {
            return userManager.AddToRole(userId, roleName);
        }
    }
}
