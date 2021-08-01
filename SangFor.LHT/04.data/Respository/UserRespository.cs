using _03.领域.DbContexts;
using _03.领域.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.data.EF
{
    public class UserRespository : IUserRespository
    {
        public UserRespository()
        {
            Console.WriteLine("我是EF 构造器。。。。。");
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Add(User user)
        {
            DbContext.Users.Add(user);
            return 1;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Update(User user)
        {
            User model = DbContext.Users.Single(x => x.Id == user.Id);

            model.Password = user.Password;
            model.Status = user.Status;
            model.LastLoginTime = user.LastLoginTime;
            model.userName = user.userName;
             return 1;
        }

        /// <summary>
        /// 获取对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetById(int id)
        {
            return DbContext.Users.Single(x => x.Id == id);
        }

        /// <summary>
        /// 获取对象
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public User GetByEmail(string email)
        {
            return DbContext.Users.SingleOrDefault(x => x.Email == email);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<User> List()
        {
            return DbContext.Users.ToList();
        }
    }
}
