using System;
using AgendaTelefonica.Enums.ETypeAccount;

namespace AgendaTelefonica.Entities.UserClient
{
    public abstract class User
    {
        protected User(Guid id, string name, int password, string email )
        {
            Id = Guid.NewGuid();
            Name = name;
            Password = password;
            Email = email;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Password { get; private set; }
        public string Email { get; private set; }
    }
}