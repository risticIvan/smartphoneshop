using SmartphoneShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneShop.Interfaces
{
    public interface IShopRepository
    {
        IQueryable<Shop> GetAll();
        Shop GetById(int id);
        void Add(Shop shop);
        void Update(Shop shop);
        void Delete(Shop shop);
    }
}
