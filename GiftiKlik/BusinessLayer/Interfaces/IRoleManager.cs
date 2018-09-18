using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IRoleManager
    {
        IdentityResult CreateRole(IdentityRole role);
        bool RoleExists(string roleName);
    }
}
