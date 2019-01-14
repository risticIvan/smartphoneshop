using SmartphoneShop.Interfaces;
using SmartphoneShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace SmartphoneShop.Repository
{
    public class ShopRepository : IDisposable, IShopRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IQueryable<Shop> GetAll()
        {
            return db.Shops;
        }

        public Shop GetById(int id)
        {
            return db.Shops.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Shop shop)
        {
            db.Shops.Add(shop);
            db.SaveChanges();
        }

        public void Update(Shop shop)
        {
            db.Entry(shop).State = EntityState.Modified;
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void Delete(Shop shop)
        {
            db.Shops.Remove(shop);
            db.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}