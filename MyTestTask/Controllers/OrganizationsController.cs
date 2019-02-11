using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTestTask.Models;

namespace MyTestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        private IRepository<Organization> db;

        public OrganizationsController(IRepository<Organization> context)
        {
           this.db = context;
            if (!db.GetAllItems().Any())
            {
                db.Create(new Organization { Name = "Tom", Code=5, Id=4, Owner="4f", Type=Types.Inc });

            }
        }

        // GET: api/Organizations
        [HttpGet]
        public IEnumerable<Organization> Get()
        {
            return db.GetAllItems();
        }

        //// GET: api/Organizations/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetOrganization([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var organization = await _context.Organizations.FindAsync(id);

        //    if (organization == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(organization);
        //}

        //// PUT: api/Organizations/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutOrganization([FromRoute] int id, [FromBody] Organization organization)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != organization.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(organization).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!OrganizationExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Organizations
        //[HttpPost]
        //public async Task<IActionResult> PostOrganization([FromBody] Organization organization)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Organizations.Add(organization);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetOrganization", new { id = organization.Id }, organization);
        //}

        //// DELETE: api/Organizations/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteOrganization([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var organization = await _context.Organizations.FindAsync(id);
        //    if (organization == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Organizations.Remove(organization);
        //    await _context.SaveChangesAsync();

        //    return Ok(organization);
        //}

        //private bool OrganizationExists(int id)
        //{
        //    return _context.Organizations.Any(e => e.Id == id);
        //}
    }
}