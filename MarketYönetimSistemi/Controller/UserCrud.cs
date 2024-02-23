using MarketYönetimSistemi.Entity.Interfaces;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketYönetimSistemi.Data;

namespace MarketYönetimSistemi.Controller
{
    public class UserCrud : ICrud<User>
    {
        DataContext db = new DataContext();
        public bool Add(User entity)
        {
            if (entity != null
                 && !String.IsNullOrWhiteSpace(entity.Name)
                 && !String.IsNullOrWhiteSpace(entity.Surname)
                 && !String.IsNullOrWhiteSpace(entity.Email)
                 && !String.IsNullOrWhiteSpace(entity.Password))
            {
                db.User.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var user = db.Product.Find(id);
            if (user != null)
            {

                user.IsDelete = true;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<User> GetAll()
        {
            return db.User.Where(x => x.IsDelete == false).ToList();
        }

        public User GetById(int id)
        {
            var user = db.User.Find(id);
            if (user != null && !user.IsDelete)
            {
                return user;
            }
            return null;
        }

        public bool Update(User entity, int id)
        {
            var user = db.User.Find(id);
            if (user != null && !user.IsDelete)
            {
                user.Name = entity.Name;
                user.Surname = entity.Surname;
                user.Description = entity.Description;
                user.Email = entity.Email;
                user.Password = entity.Password;
                user.Image = entity.Image;
                
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
