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
    public class SmartphoneRepository : IDisposable, ISmartphoneRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IQueryable<Smartphone> GetAll()
        {
            return db.Smartphones;
        }

        public Smartphone GetById(int id)
        {
            return db.Smartphones.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Smartphone smartphone)
        {
            db.Smartphones.Add(smartphone);
            db.SaveChanges();
        }

        public void Update(Smartphone smartphone)
        {
            db.Entry(smartphone).State = EntityState.Modified;
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void Delete(Smartphone smartphone)
        {
            db.Smartphones.Remove(smartphone);
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