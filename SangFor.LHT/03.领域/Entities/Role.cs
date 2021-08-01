using System;
using System.Collections.Generic;
using System.Text;

namespace _03.领域.Entities
{
    public class Role
    {

        /// <summary>
        /// 主键
        /// </summary>
        public Guid guid { get; set; }

        /// <summary>
        /// 角色Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 角色名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public RoleType RoleType { get; set; }
        /// <summary>
        /// 角色注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

    }
    
    public enum RoleType
    {
        /// <summary>
        /// 超级管理员
        /// </summary>
        admin = 1,
        /// <summary>
        /// 用户
        /// </summary>
        user = 2,
        /// <summary>
        /// 游客
        /// </summary>
        vistor = 3
    }
}
