using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 订单
    /// </summary>
    public class Orders
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string Ordercode { get; set; }
        /// <summary>
        ///产品名称
        /// </summary>
        public string Productname { get; set; }
        /// <summary>
        ///联系人名称
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        ///联系人电话
        /// </summary>
        public string CustomerPhone { get; set; }
        /// <summary>
        ///联系人身份证
        /// </summary>
        public string CutomerIdcard { get; set; }
        /// <summary>
        ///订单状态
        /// </summary>
        public bool Orderstate { get; set; }
        /// <summary>
        ///支付状态
        /// </summary>
        public string Paystate
        {
            get
            {
                if (Orderassign.Where(x => x.Paid == true).Count() == 0)
                {
                    return "未支付";
                }
                else if (Orderassign.Where(x => x.Paid == false).Count() == 0)
                {
                    return "已支付";
                }
                else
                {
                    return "部分已支付";
                }
            }
            private set;
        }
        /// <summary>
        ///支付方式
        /// </summary>
        public Payway Payway { get; set; }
        /// <summary>
        ///验票状态
        /// </summary>
        public string Checkstate
        {
            get
            {
                if (Orderassign.Where(x => x.State == true).Count() == 0)
                {
                    return "未检票";
                }
                else if (Orderassign.Where(x => x.State == false).Count() == 0)
                {
                    return "检票完成";
                }
                else
                {
                    return "部分已检票";
                }
            }
            private set;
        }
        /// <summary>
        ///总数量
        /// </summary>
        public int Totalnum { get { return Orderassign.Count; } private set; }
        /// <summary>
        ///验票数量
        /// </summary>
        public int Checkednum { get; set; }
        /// <summary>
        ///退票数量
        /// </summary>
        public int Rebacknum { get; set; }
        /// <summary>
        ///订单分配集合
        /// </summary>
        public IList<Orderassign> Orderassign { get; set; }
        /// <summary>
        ///产品价格
        /// </summary>
        public double Productprice { get; set; }
        /// <summary>
        ///产品总价
        /// </summary>
        public double Totalprice { get { return Productprice * Totalnum; } set; }
        /// <summary>
        ///产品
        /// </summary>
        public Product_Ticket Product_Ticket { get; set; }
        /// <summary>
        ///是否结算
        /// </summary>
        public bool IsClear { get; set; }
    }
    /// <summary>
    /// 订单明细
    /// </summary>
    public class Orderassign
    {
        /// <summary>
        ///主键Id
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        ///验票点
        /// </summary>
        public string Checkplace { get; set; }
        /// <summary>
        ///产品
        /// </summary>
        public Product_Ticket Product { get; set; }
        /// <summary>
        ///验票时间
        /// </summary>
        public DateTime Checktime { get; set; }
        /// <summary>
        ///验票状态
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        ///是否支付
        /// </summary>
        public bool Paid { get; set; }
    }

    public enum Payway { }
}
