using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Peeps.Models;
using Raven.Client.Embedded;
using Raven.Database.Server.Responders;

namespace Peeps
{
    public class SeedData
    {
        public void Seed()
        {
            var session = Db.GetSession();
            var count = session.Query<Peep>().Count();
            if (count > 0) return;

            foreach (var peep in Generate())
            {
                session.Store(peep);
            }
            session.SaveChanges();
        }

        private static IEnumerable<Peep> Generate()
        {
            yield return new Peep
            {
                Title = "Ms",
                FirstName = "Alice",
                LastName = "Arbuthnot",
                Address = new Address {Line1 = "1 The Road", Town = "Townville", County = "Countyshire"},
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber {Type = "Mobile", AreaCode = "01234", Number = "567890"},
                    new PhoneNumber {Type = "Home", AreaCode = "09876", Number = "543210"},
                },
                EmailAddresses = new List<Email>
                {
                    new Email{ Type = "Personal", Address = "alice@mail.com" }
                }
            };
            yield return new Peep
            {
                Title = "Mr",
                FirstName = "Bob",
                LastName = "Barker",
                Address = new Address {Line1 = "2 The Road", Town = "Townville", County = "Countyshire"},
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber {Type = "Mobile", AreaCode = "01111", Number = "111111"},
                    new PhoneNumber {Type = "Home", AreaCode = "09999", Number = "999999"},
                },
                EmailAddresses = new List<Email>
                {
                    new Email{ Type = "Personal", Address = "bob@mail.com" }
                }
            };
            yield return new Peep
            {
                Title = "Dr",
                FirstName = "Charlie",
                LastName = "Chester",
                Address = new Address {Line1 = "3 The Road", Town = "Townville", County = "Countyshire"},
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber {Type = "Mobile", AreaCode = "02222", Number = "222222"},
                    new PhoneNumber {Type = "Home", AreaCode = "09999", Number = "555555"},
                },
                EmailAddresses = new List<Email>
                {
                    new Email{ Type = "Personal", Address = "charlie@mail.com" }
                }
            };
            yield return new Peep
            {
                Title = "Mr",
                FirstName = "David",
                LastName = "Dunworthy",
                Address = new Address { Line1 = "1 A Street", Town = "Metrocity", County = "Othershire" },
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber {Type = "Mobile", AreaCode = "03333", Number = "333333"},
                },
                EmailAddresses = new List<Email>
                {
                    new Email{ Type = "Personal", Address = "david@mail.com" }
                }
            };
            yield return new Peep
            {
                Title = "Ms",
                FirstName = "Elaine",
                LastName = "Englebert",
                Address = new Address { Line1 = "2 A Street", Town = "Metrocity", County = "Othershire" },
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber {Type = "Home", AreaCode = "04444", Number = "444444"},
                },
                EmailAddresses = new List<Email>
                {
                    new Email{ Type = "Personal", Address = "elaine@mail.com" }
                }
            };
            yield return new Peep
            {
                Title = "Mrs",
                FirstName = "Frances",
                LastName = "Fedora",
                Address = new Address { Line1 = "3 A Street", Town = "Metrocity", County = "Othershire" },
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber {Type = "Mobile", AreaCode = "05555", Number = "555555"},
                    new PhoneNumber {Type = "Home", AreaCode = "06666", Number = "666666"},
                },
                EmailAddresses = new List<Email>
                {
                    new Email{ Type = "Personal", Address = "frances@mail.com" }
                }
            };
            yield return new Peep
            {
                Title = "Mr",
                FirstName = "George",
                LastName = "Garrett",
                Address = new Address { Line1 = "4 A Street", Town = "Metrocity", County = "Othershire" },
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber {Type = "Mobile", AreaCode = "07777", Number = "777777"},
                    new PhoneNumber {Type = "Home", AreaCode = "08888", Number = "888888"},
                },
                EmailAddresses = new List<Email>
                {
                    new Email{ Type = "Personal", Address = "george@mail.com" }
                }
            };
            yield return new Peep
            {
                Title = "Mr",
                FirstName = "Henry",
                LastName = "Huddlestone",
                Address = new Address { Line1 = "5 A Street", Town = "Metrocity", County = "Othershire" },
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber {Type = "Mobile", AreaCode = "01919", Number = "191919"},
                    new PhoneNumber {Type = "Home", AreaCode = "02828", Number = "282828"},
                },
                EmailAddresses = new List<Email>
                {
                    new Email{ Type = "Personal", Address = "henry@mail.com" }
                }
            };
            yield return new Peep
            {
                Title = "Ms",
                FirstName = "Isabel",
                LastName = "Inkhorn",
                Address = new Address { Line1 = "6 A Street", Town = "Metrocity", County = "Othershire" },
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber {Type = "Mobile", AreaCode = "03737", Number = "373737"},
                    new PhoneNumber {Type = "Home", AreaCode = "04646", Number = "464646"},
                },
                EmailAddresses = new List<Email>
                {
                    new Email{ Type = "Personal", Address = "isabel@mail.com" }
                }
            };
            yield return new Peep
            {
                Title = "Miss",
                FirstName = "Jane",
                LastName = "Jenkins",
                Address = new Address { Line1 = "7 A Street", Town = "Metrocity", County = "Othershire" },
                PhoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber {Type = "Mobile", AreaCode = "09191", Number = "919191"},
                    new PhoneNumber {Type = "Home", AreaCode = "08282", Number = "828282"},
                },
                EmailAddresses = new List<Email>
                {
                    new Email{ Type = "Personal", Address = "jane@mail.com" }
                }
            };
        }
    }
}