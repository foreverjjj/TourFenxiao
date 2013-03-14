using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 分销商关系表
    /// </summary>
    public class FenxTicketOrigin
    {
        public int ID { get; set; }
        public Product_Ticket Product_Ticket { get; set; }
        public Enterprise_Atractions Enterprise_Atractions { get; set; }
        public Enterprise_Fenx Enterprise_Fenx { get; set; }
        public double Checkoutprice { get; set; }
    }
}
