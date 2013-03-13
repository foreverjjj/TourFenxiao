using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class EnterproductRelation
    {
        public int ID { get; set; }
        public Enterprise Enterprise { get; set; }
        public Product Product { get; set; }
    }
}
