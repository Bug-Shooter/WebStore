using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models.Users
{
    public class Address
    {
        public int ID { get; set; }
        public string Contry { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Buiding { get; set; }
        public User User { get; set; }

    }
}
