using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models.Specs;

namespace WebStore.Models.Products
{
    public class LCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public Category Category { get; set; }
        public SpecList SpecList { get; set; }
    }
}
