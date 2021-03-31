using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models.Products;

namespace WebStore.Models.Specs
{
    public class SpecList
    {
        public int ID { get; set; }
        public ICollection<LCategory> Categories { get; set; }
        public ICollection<Spec> Specs { get; set; }
    }
}
