using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class FenxHotelOrigin
    {
        public int ID { get; set; }
        public Product_Room Product_Room { get; set; }
        public Enterprise_Atractions Enterprise_Atractions { get; set; }
        public Enterprise_Fenx Enterprise_Fenx { get; set; }
        public double Checkoutprice { get; set; }
    }
}
