using _03.领域.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02.应用服务.IService
{
    public interface IUserService
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool Reg(User user);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool Login(User user);
        /// <summary>
        /// 根据Id获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User GetById(int id);

        /// <summary>
        /// 根据邮箱获取对象
        /// </summary>
        /// <param name="emial"></param>
        /// <returns></returns>
        User ExistByEmail(string emial);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<User> GetList();
    }
}
