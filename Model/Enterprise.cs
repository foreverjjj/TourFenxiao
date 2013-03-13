using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 机构（包括供应商、各级分销商）
    /// </summary>
    public class Enterprise
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 行政父ID
        /// </summary>
        public int Parent_Adminid { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 英文名称
        /// </summary>
        public string Ename { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Telphone { get; set; }
        /// <summary>
        /// 电子邮件
        /// </summary>
        public string Email{get;set;}
        /// <summary>
        /// 传真
        /// </summary>
        public string Fax{get;set;}
        /// <summary>
        /// 网站
        /// </summary>
        public string Website{get;set;}
        /// <summary>
        /// 负责人
        /// </summary>
        public string Chargename { get; set; }
        /// <summary>
        /// 负责人电话
        /// </summary>
        public string Chargephone { get; set; }
        /// <summary>
        /// 商业类型
        /// </summary>
        public Etp_TradeType Etp_TradeType { get; set; }
        /// <summary>
        /// 行政类型
        /// </summary>
        public Etp_AdminType Etp_AdminType { get; set; }
        /// <summary>
        /// 所属地区
        /// </summary>
        public Area Area { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int Level { get; set; }

    }

    /// <summary>
    /// 商业类型
    /// </summary>
    public enum Etp_TradeType
    {
        供应商,
        分销商,
    }

    /// <summary>
    /// 行政类型
    /// </summary>
    public enum Etp_AdminType
    { 
        管理部门,
        景区,
        旅行社,
        住宿,
        餐饮
    }
}
