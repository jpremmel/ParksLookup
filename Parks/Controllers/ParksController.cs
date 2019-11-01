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
    }
}