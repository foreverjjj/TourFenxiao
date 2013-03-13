using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 产品线
    /// </summary>
    public class Productline
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// /产品线名称
        /// </summary>
        public string Name { get; set; }
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
        /// 是否默认
        /// </summary>
        public bool Isdefult { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Isuseful { get; set; }
    }
}
