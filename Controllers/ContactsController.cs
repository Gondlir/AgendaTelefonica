using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AgendaTelefonica.Entities;
using AgendaTelefonica.Data;

namespace AgendaTelefonica.Controllers
{
    [ApiController]
    [Route("v1/agendatelefonica")]
    public class ContactsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Contacts>>> Get([FromServices] UserDbContext context)
        {
            var contactos = await context.Contacts.ToListAsync();
            return contactos;
        }
        [HttpGet]
        [Route("{number:int}")]
        public async Task<ActionResult<Contacts>> GetByNumber([FromServices] UserDbContext context, int number)
        {
            var contact = await context.Contacts.Include(x => x.Id).AsNoTracking()
            .FirstOrDefaultAsync(x => x.PhoneNumber == number);
            return contact;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Contacts>> Post([FromServices] UserDbContext context, [FromBody] Contacts model)
        {
            if (ModelState.IsValid)
            {
                context.Contacts.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}