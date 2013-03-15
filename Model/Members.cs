using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Members
    {
        /// <summary>
        /// id
        /// </summary>
        public virtual Guid Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public virtual string Password { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public virtual string RealName { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public virtual string Phone { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public virtual string Address { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public virtual string IdCard { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public virtual string Email { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime Createtime { get; set; }
        /// <summary>
        /// 最后登陆时间
        /// </summary>
        public virtual DateTime lastLogin { get; set; }
        /// <summary>
        /// 所属单位
        /// </summary>
        public virtual Enterprise Enterpise { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public virtual Roleship Roleship { get; set; }
    }

    /// <summary>
    /// 角色
    /// </summary>z
    public class Roleship
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual int Rightvalue { get; set; }
    }

    /// <summary>
    /// 权限枚举（根据左侧导航列表分类）
    /// </summary>
    public enum Rightship { 
        
    }
}
