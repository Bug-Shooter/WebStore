using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models.Orders;
using WebStore.Models.Users;

namespace WebStore.Models
{
     public class User : IdentityUser
     {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string BirthDay { get; set; }
        [NotMapped]
        public Cart Cart { get; set; }
        public List<Address> Addresses { get; set; }
        public List<OrderList> OrderLists { get; set; }
    }
}
