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
    public class SmartphonesController : ApiController
    {
        ISmartphoneRepository repo { get; set; }

        public SmartphonesController(ISmartphoneRepository repository)
        {
            repo = repository;
        }

        public IQueryable<Smartphone> Get()
        {
            return repo.GetAll();
        }

        public IHttpActionResult Get(int id)
        {
            var smartphone = repo.GetById(id);
            if (smartphone == null)
            {
                return NotFound();
            }
            return Ok(smartphone);
        }

        //[Route("api/search")]
        //public IQueryable<Smartphone> GetFilter(int start, int kraj)
        //{
        //    return repo.GetByCriteria(start, kraj);
        //}

        //[Route("api/power")]
        //public IQueryable<Car> GetPower()
        //{
        //    return repo.GetByPower();
        //}

        //[Route("api/price")]
        //public IQueryable<Car> GetCheapest()
        //{
        //    return repo.GetByPrice();
        //}

        public IHttpActionResult Post(Smartphone smartphone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            repo.Add(smartphone);
            return CreatedAtRoute("DefaultApi", new { id = smartphone.Id }, smartphone);
        }

        public IHttpActionResult Put(int id, Smartphone smartphone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != smartphone.Id)
            {
                return BadRequest();
            }
            try
            {
                repo.Update(smartphone);
            }
            catch
            {
                return BadRequest();
            }
            return Ok(smartphone);
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var smartphone = repo.GetById(id);
            if (smartphone == null)
            {
                return NotFound();
            }
            repo.Delete(smartphone);
            return Ok();
        }
    }
}
