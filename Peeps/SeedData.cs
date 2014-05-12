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
                }
            };
        }
    }
}