using HerosWebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HerosWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        private readonly HerosDBContext fruitsDB;

        public FruitsController(HerosDBContext appDB)
        {
            fruitsDB = appDB;
        }

        [HttpGet]
        public IActionResult GetFruits()
        {
            return Ok(fruitsDB.fruits.ToList());
        }
        [HttpPost]
        public IActionResult PostFruits(Fruits fruits)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            fruitsDB.fruits.Add(fruits);
            fruitsDB.SaveChanges();
            return Ok("Fruits Data Added Successfully");
        }
    }
}
