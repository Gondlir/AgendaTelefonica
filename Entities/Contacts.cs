using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgendaTelefonica.Entities
{
    public class Contacts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
    }
}