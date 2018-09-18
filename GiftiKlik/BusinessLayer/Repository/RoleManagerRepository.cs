
using BusinessLayer.Interfaces;
using DataLayer;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace BusinessLayer.Repository
{
    public class RoleManagerRepository : IRoleManager
    {
        private ApplicationDbContext context;
        private RoleManager<IdentityRole> roleManager;

        public RoleManagerRepository()
        {
            context = new ApplicationDbContext();
            roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        }

        public IdentityResult CreateRole(IdentityRole role)
        {
            return roleManager.Create(role);
        }

        public bool RoleExists(string roleName)
        {
            return roleManager.RoleExists(roleName);
        }
    }
}
