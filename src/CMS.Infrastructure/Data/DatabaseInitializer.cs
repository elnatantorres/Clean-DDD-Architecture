using System.Linq;
using CMS.ApplicationCore.Entity;
using CMS.Infrastructure.Data;

namespace CMS.Infrastructure
{
    public static class DatabaseInitializer
    {
        public static void Initialize(ClientContext context)
        {
            if(context.Clients.Any())
                return;

            var clients = new Client[]
            {
                new Client {
                    Name = "Fulano",
                    CPF = "47898709814",
                },
                new Client {
                    Name = "Cicrano",
                    CPF = "76598709812"
                }
            };

            context.Clients.AddRange(clients);

            var contacts = new Contact[]

            {
                new Contact {
                    Name = "Contato 1",
                    Email = "contato1@hotmail.com",
                    Client = clients[0],
                    PhoneNumber = "998765432"
                },
                new Contact {
                    Name = "Contato 2",
                    Email = "contato2@hotmail.com",
                    Client = clients[1],
                    PhoneNumber = "987675675"
                }
            };

            context.Contacts.AddRange(contacts);

            context.SaveChanges();
        }
    }
}