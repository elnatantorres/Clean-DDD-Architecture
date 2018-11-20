namespace CMS.ApplicationCore.Entity
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; } 
    }
}