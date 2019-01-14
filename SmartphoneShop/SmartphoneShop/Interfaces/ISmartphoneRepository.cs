using SmartphoneShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneShop.Interfaces
{
    public interface ISmartphoneRepository
    {
        IQueryable<Smartphone> GetAll();
        Smartphone GetById(int id);
        void Add(Smartphone smartphone);
        void Update(Smartphone smartphone);
        void Delete(Smartphone smartphone);
    }
}
