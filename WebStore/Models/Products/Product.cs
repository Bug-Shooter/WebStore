using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models.Products
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public LCategory LCategory { get; set; }
        public int Ammount { get; set; }
        public int Price { get; set; }
        public int OldPrice { get; set; }
        public string Descriprion { get; set; }
        public int SellAmmount { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        public bool IsSelling { get; set; }
    }
}
