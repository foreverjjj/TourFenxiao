using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 分销商关系表
    /// </summary>
    public class FenxHotelSub
    {
        public int ID { get; set; }
        public Product_Room Product_Room { get; set; }
        public Enterprise_Fenx Enterprise_Fenx1 { get; set; }
        public Enterprise_Fenx Enterprise_Fenx2 { get; set; }
        public double Checkoutprice { get; set; }
    }
}
