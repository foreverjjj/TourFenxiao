using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class AreaDistict
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string SeoName { get; set; }
        /// <summary>
        /// 身份证前6位
        /// </summary>
        public virtual string Code { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public virtual string Zip { get; set; }
        /// <summary>
        /// 电话区号
        /// </summary>
        public virtual string Telcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int AreaOrder { get; set; }
        public virtual string MetaDescription { get; set; }
    }
}
