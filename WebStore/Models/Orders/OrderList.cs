using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models.Orders
{
    public class OrderList
    {
        public int ID { get; set; }
        public User User { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int TotalCost { get; set; }
        public ICollection<Order> Orders { get; set; }

}
}
