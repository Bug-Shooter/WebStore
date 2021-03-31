using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models.Specs
{
    public class Spec
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Value { get; set; }
        public ICollection<SpecList> SpecLists{ get; set; }
    }
}

