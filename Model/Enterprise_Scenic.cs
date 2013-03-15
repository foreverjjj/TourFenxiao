using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 机构（包括供应商、各级分销商）
    /// </summary>
    public class Enterprise_Scenic:Enterprise
    {
        
        /// <summary>
        /// 等级
        /// </summary>
        public string Level { get; set; }
        /// <summary>
        /// 管辖的景点
        /// </summary>
        public IList<Enterprise_Atractions> EnterpriseAtractions { get; set; }
    }
}
