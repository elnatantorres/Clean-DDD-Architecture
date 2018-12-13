namespace CMS.ApplicationCore.Entity
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public string Reference { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}