using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models.Products;

namespace WebStore.Models.Orders
{
    public class Order
    {
        public int ID { get; set; }
        public string ProdName { get; set; }
        public int Amount { get; set; }
        public int UnitPrice { get; set; }
        public int TotalCost { get; set; }
        public Product Product { get; set; }
        public OrderList OrderList { get; set; }

    }
}
