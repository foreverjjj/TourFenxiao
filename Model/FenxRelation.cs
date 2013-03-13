using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 分销商关系表
    /// </summary>
    public class FenxRelation
    {
        public int ID { get; set; }
        public Productline Productline { get; set; }
        public Enterprise EnterpriseParent { get; set; }
        public Enterprise EnterpriseChild { get; set; }
        public int Level { get; set; }
    }
}
