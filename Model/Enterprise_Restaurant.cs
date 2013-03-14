using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Enterprise_Restaurant
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
        /// 商业父ID
        /// </summary>
        public int Parent_Tradeid { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
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
        public string Email { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// 网站
        /// </summary>
        public string Website { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        public string Chargename { get; set; }
        /// <summary>
        /// 负责人电话
        /// </summary>
        public string Chargephone { get; set; }
        /// <summary>
        /// 所属省份
        /// </summary>
        public AreaProvince AreaProvince { get; set; }
        /// <summary>
        /// 所属市区
        /// </summary>
        public AreaCity AreaCity { get; set; }
        /// <summary>
        /// 所属区县
        /// </summary>
        public AreaDistict AreaDistict { get; set; }
        /// <summary>
        /// 省份（冗余字段）
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 城市（冗余字段）
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 区域（冗余字段）
        /// </summary>
        public string Distict { get; set; }
        /// <summary>
        /// 商业街区
        /// </summary>
        public string BusinessZone { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public string Star { get; set; }
        public string Category { get; set; }
        public string Availpolicy { get; set; }
        public string Position { get; set; }
        public Brand Brand { get; set; }
    }
}
