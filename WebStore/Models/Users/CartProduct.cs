using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models.Products;

namespace WebStore.Models.Users
{
    public class CartProduct
    {
        public Product Product { get; set; }
        public int Ammount { get; set; }
    }
}
