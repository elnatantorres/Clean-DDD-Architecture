using System.Collections.Generic;

namespace CMS.ApplicationCore.Entity
{
    public class Client
    {
        public int ClientId {get; set; }
        public string Name {get; set; }
        public string CPF {get; set; }
        public ICollection<Contact> Contacts { get; set; } 
    }
}