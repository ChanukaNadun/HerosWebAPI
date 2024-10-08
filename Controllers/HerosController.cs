using HerosWebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HerosWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerosController : ControllerBase
    {
        private readonly HerosDBContext _db;
        public HerosController(HerosDBContext appDB)
        {
            _db = appDB;
        }

        [HttpGet]
        public IActionResult GetHerosData() 
        {
            return Ok(_db.heros.ToList());
        }

        [HttpPost]
        public IActionResult PostHerosData(Heros heros)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            _db.heros.Add(heros);
            _db.SaveChanges();
            return Ok("Data Added Successfully");
        }
    }
}
