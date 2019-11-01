using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Parks.Models;
using Microsoft.EntityFrameworkCore;

namespace Parks.Controllers
{
    [Route("api/[controller]")] //Route: "api/parks"
    [ApiController]
    public class ParksController : ControllerBase
    {
        private ParksContext _db;

        public ParksController(ParksContext db)
        {
            _db = db;
        }

        //GET api/parks
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get (string name, string location, string terrain, string description)
        {
            var query = _db.Parks.AsQueryable();
            if (name != null)
            {
                query = query.Where(p => p.Name.ToLower().Contains(name.ToLower()));
            }
            if (location != null)
            {
                query = query.Where(p => p.Location.ToLower().Contains(location.ToLower()));
            }
            if (terrain != null)
            {
                query = query.Where(p => p.Terrain.ToLower().Contains(terrain.ToLower()));
            }
            if (description != null)
            {
                query = query.Where(p => p.Description.ToLower().Contains(description.ToLower()));
            }
            return query.ToList();
        }

        //GET api/parks/{id}
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
            return _db.Parks.FirstOrDefault(p => p.ParkId == id);
        }

        //POST api/parks
        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }

        //PUT api/parks/{id}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park park)
        {
            park.ParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/parks/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.Parks.FirstOrDefault(p => p.ParkId == id);
            _db.Parks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}