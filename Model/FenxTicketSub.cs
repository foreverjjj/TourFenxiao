using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class FenxTicketSub
    {
        public int ID { get; set; }
        public Product_Ticket Product_Ticket { get; set; }
        public Enterprise_Fenx Enterprise_Fenx1 { get; set; }
        public Enterprise_Fenx Enterprise_Fenx2 { get; set; }
        public double Checkoutprice { get; set; }
    }
}
