using System;
using AgendaTelefonica.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaTelefonica.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<Contacts> Contacts { get; set; }
    }
}