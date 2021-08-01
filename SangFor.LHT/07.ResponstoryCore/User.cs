using System;
using System.Collections.Generic;
using System.Text;

namespace _07.ResponstoryCore
{
    public class User
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime RegTime { get; set; }
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool Status { get; set; }
    }
}
