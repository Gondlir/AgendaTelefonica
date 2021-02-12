using System;
using AgendaTelefonica.Entities;

namespace AgendaTelefonica.Entities.UserClient
{
    public class UserClient : User
    {
        public UserClient(Guid id, string name, int password, string email) : base(id, name, password, email)
        {
            ClientId = Guid.NewGuid();
            ClientName = name;
            ClientPassword = password;
            EmailUser = email;
        }

        public Guid ClientId { get; private set; }
        public string ClientName { get; private set; }
        public int ClientPassword { get; private set; }
        public string EmailUser { get; private set; }
        public Contacts Contatos { get; set; }
    }
}