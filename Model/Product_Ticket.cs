using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Product_Ticket
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 英文名
        /// </summary>
        public string Ename { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime Begintime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime Endtime { get; set; }
        /// <summary>
        /// 排序顺序
        /// </summary>
        public int Productorder { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public Members CreateMember { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Createtime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public Members ModifyMember { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime Modifytime { get; set; }
        /// <summary>
        /// 如果是联票中的子票，则需要有parentid
        /// </summary>
        public int ParentID { get; set; }
        /// <summary>
        /// 普通价
        /// </summary>
        public double Ticketprice1 { get; set; }
        /// <summary>
        /// 预订价
        /// </summary>
        public double Ticketprice2 { get; set; }
        /// <summary>
        /// 在线支付价
        /// </summary>
        public double Ticketprice3 { get; set; }
        /// <summary>
        /// 分销商结算价
        /// </summary>
        public double Ticketprice4 { get; set; }
        public double Ticketprice5 { get; set; }
    }
}
