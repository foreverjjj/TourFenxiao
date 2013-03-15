using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class HistoryFenxiaoDishPrice
    {
        public int ID { get; set; }
        public Enterprise_Fenx Enterprise_Fenx { get; set; }
        public Product_Dish Product_Ticket { get; set; }
        public double Price1 { get; set; }
        public double Price2 { get; set; }
        public double Price3 { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime CreateMember { get; set; }
        public bool Enabled { get; set; }
    }
}
