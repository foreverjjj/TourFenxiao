using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 产品与产品线关系表
    /// </summary>
    public class LineRelation
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 产品
        /// </summary>
        public Product_Room Product { get; set; }
        /// <summary>
        /// 产品线
        /// </summary>
        public Productline Productline { get; set; }

    }
}
