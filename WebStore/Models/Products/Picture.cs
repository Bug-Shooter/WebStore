using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models.Products
{
    public class Picture
    {
         public int ID { get; set; }
         public string Name { get; set; }
         public string Path { get; set; }
         public Product Product { get; set; }
    }
}
