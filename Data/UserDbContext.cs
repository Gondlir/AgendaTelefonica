using System;
using AgendaTelefonica.Entities.UserClient;
using AgendaTelefonica.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaTelefonica.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<UserClient> Usuarios { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
    }
}