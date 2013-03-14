using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class FenxRestaurantOrigin
    {
        public int ID { get; set; }
        public Product_Dish Product_Dish { get; set; }
        public Enterprise_Restaurant Enterprise_Atractions { get; set; }
        public Enterprise_Fenx Enterprise_Fenx { get; set; }
        public double Checkoutprice { get; set; }
    }
}
