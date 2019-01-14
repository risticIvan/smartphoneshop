using SmartphoneShop.Interfaces;
using SmartphoneShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartphoneShop.Controllers
{
    public class ShopController : ApiController
    {
        IShopRepository repo { get; set; }

        public ShopController(IShopRepository repository)
        {
            repo = repository;
        }

        public IQueryable<Shop> Get()
        {
            return repo.GetAll();
        }

        public IHttpActionResult Get(int id)
        {
            var shop = repo.GetById(id);
            if (shop == null)
            {
                return NotFound();
            }
            return Ok(shop);
        }

        public IHttpActionResult Post(Shop shop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            repo.Add(shop);
            return CreatedAtRoute("DefaultApi", new { id = shop.Id }, shop);
        }

        public IHttpActionResult Put(int id, Shop shop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != shop.Id)
            {
                return BadRequest();
            }
            try
            {
                repo.Update(shop);
            }
            catch
            {
                return BadRequest();
            }
            return Ok(shop);
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var shop = repo.GetById(id);
            if (shop == null)
            {
                return NotFound();
            }
            repo.Delete(shop);
            return Ok();
        }
    }
}
