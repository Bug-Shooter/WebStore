using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models.Products
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<LCategory> LCategories { get; set; }
        //public Picture logo { get; set; } //Добавить с апдейтом
    }
}
