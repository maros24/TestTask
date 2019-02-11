using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyTestTask.Models;

namespace MyTestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        IRepository<User> db;
        
        public UserController(IRepository<User> context)
        {
            this.db = context;
            if (!db.GetAllItems().Any())
            {
                db.Create(new User { Name = "Tom", SurName = "Lol", Email="wrg", Adress="df"});
               
            }
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.GetAllItems();
        }






        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
