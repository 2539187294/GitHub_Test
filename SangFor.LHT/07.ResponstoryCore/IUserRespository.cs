using System;
using System.Collections.Generic;
using System.Text;

namespace _07.ResponstoryCore
{
    public interface IUserRespository
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int Add(User user);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int Update(User user);

        /// <summary>
        /// 获取对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User GetById(int id);

        /// <summary>
        /// 获取对象
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        User GetByEmail(string email);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<User> List();
    }
}
