using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Product_Room
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
        /// 房间类型
        /// </summary>
        public roomType roomType { get; set; }
        /// <summary>
        /// 英文名（seoname）
        /// </summary>
        public string Ename { get; set; }
        /// <summary>
        /// 面积
        /// </summary>
        public int Area { get; set; }
        /// <summary>
        /// 层数
        /// </summary>
        public string roomFloor { get; set; }
        /// <summary>
        /// 是否有宽带
        /// </summary>
        public bool HasBroadNet { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// 房间描述
        /// </summary>
        public string RoomDesc { get; set; }
        /// <summary>
        /// 床描述
        /// </summary>
        public string BedDesc { get; set; }
        /// <summary>
        /// 是否是联票
        /// </summary>
        public bool IsUnionTicket { get; set; }
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
        /// 如果是联票中的子票，则需要有parentid
        /// </summary>
        public int ParentID { get; set; }
        /// <summary>
        /// 普通价
        /// </summary>
        public double Ticketprice1 { get; set; }
        /// <summary>
        /// 所属的供应商
        /// </summary>
        public Enterprise_Restaurant Enterprise_Restaurant { get; set; }
        /// <summary>
        /// 一级分销商
        /// </summary>
        public Enterprise_Fenx Enterprise_Fenx { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 最后一次修改人
        /// </summary>
        public Members LastModifyMember { get; set; }
        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public DateTime LastModifyTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public Members CreateMember { get; set; }
    }

    public class roomType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
