using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models.Products;

namespace WebStore.Models.Users
{
    public class Cart
    {
        public User User { get; set; }
        public List<CartProduct> CartProducts { get; set; }
        public int TotalCost { get; set; }
        public void AddProd(Product Product,int Ammount)
        {
            CartProduct cartProduct = new CartProduct { Product = Product, Ammount = Ammount };
            CartProducts.Add(cartProduct);
            CartProducts.Add(cartProduct);
            CartProducts.Add(cartProduct);
        }

    }
}
