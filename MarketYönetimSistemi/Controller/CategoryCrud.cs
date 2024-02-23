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
    public class CategoryCrud : ICrud<Category> //CategoryCrud classına ICrud interface 'ini kategori türünden gönder.
    {
        DataContext db = new DataContext();
        public bool Add(Category entity)
        {
            if (entity != null)
            {
                entity.IsStatus = true;
                db.Category.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var category = db.Category.Find(id);
            if (category != null)
            {

                category.IsDelete = true;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Category> GetAll()
        {
            return db.Category.Where(x => x.IsDelete).ToList();
        }

        public Category GetById(int id)
        {
            var category = db.Category.Find(id);
            if (category != null && !category.IsDelete)
            {
                return category;
            }
            return null;
        }

        public bool Update(Category entity, int id)
        {
            var category = db.Category.Find(id);
            if (category != null && !category.IsDelete)
            {
                category.Name = entity.Name;
                category.Description = entity.Description;
                category.Image = entity.Image;
                category.IsStatus = entity.IsStatus;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
