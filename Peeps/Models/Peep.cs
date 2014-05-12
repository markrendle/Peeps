using System.Collections.Generic;

namespace Peeps.Models
{
    public class Peep
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }

    public class PhoneNumber
    {
        public string Type { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string Number { get; set; }
    }
}