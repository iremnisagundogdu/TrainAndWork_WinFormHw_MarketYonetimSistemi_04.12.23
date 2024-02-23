﻿using MarketYönetimSistemi.Entity.Interfaces;
using MarketYönetimSistemi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketYönetimSistemi.Data;

namespace MarketYönetimSistemi.Controller
{
    internal class ProductCrud : ICrud<Product>
    {
        DataContext db = new DataContext();
        public bool Add(Product entity)
        {
            if (entity != null)
            {
                entity.IsStatus = true;
                db.Product.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var product = db.Product.Find(id);
            if (product != null)
            {

                product.IsDelete = true;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Product> GetAll()
        {
            return db.Product.Where(x => x.IsDelete==false).ToList();
        }

        public Product GetById(int id)
        {
            var product = db.Product.Find(id);
            if (product != null && !product.IsDelete)
            {
                return product;
            }
            return null;
        }

        public bool Update(Product entity, int id)
        {
            var product = db.Product.Find(id);
            if (product != null && !product.IsDelete)
            {
                product.Name = entity.Name;
                product.Description = entity.Description;
                product.Price = entity.Price;
                product.Stock = entity.Stock;
                product.Category = entity.Category;
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
