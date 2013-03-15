using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class HistoryFenxiaoTicketPrice
    {
        public int ID { get; set; }
        /// <summary>
        /// 上一级供应商（也可能是分销商）
        /// </summary>
        public Enterprise Enterprise { get; set; }
        /// <summary>
        /// 接受该产品的分销商
        /// </summary>
        public Enterprise_Fenx Enterprise_Fenx { get; set; }
        public Product_Ticket Product_Ticket { get; set; }
        public double Price1 { get; set; }
        public double Price2 { get; set; }
        public double Price3 { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime CreateMember { get; set; }
        public bool Enabled { get; set; }
    }
}
