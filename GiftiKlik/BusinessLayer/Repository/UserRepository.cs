using BusinessLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository
{
    public class UserRepository : IUserGifti
    {
        private GiftiContext db;
        public UserRepository()
        {
            db = new GiftiContext();
        }

        public void AddNewUser(User user)
        {
            if(user!= null)
            {
                db.Users.Add(user);
                db.SaveChanges();
            }        
        }

        public User FindUser(string username)
        {
            throw new NotImplementedException();
        }
    }
}
