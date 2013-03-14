using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class AreaBusinessZone
    {
        public int ID { get; set; }

        public string Name { get; set; }

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
    }
}
