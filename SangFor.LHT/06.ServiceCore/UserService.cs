using _07.ResponstoryCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06.ServiceCore
{
    public class UserService :IUserService
    {
        private readonly IUserRespository _userRespository = null;

        /// <summary>
        /// 构造器
        /// </summary>
        public UserService(IUserRespository userRespository)
        {
            _userRespository = userRespository;
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Reg(User user)
        {
            //1.检查
            if (string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
            {
                return false;
            }
            //2.记录注册信息
            user.RegTime = DateTime.Now;
            user.Status = true;

            //3。baoc
            int count = _userRespository.Add(user);

            return count > 0;
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Login(User user)
        {
            //1.检查
            if (string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
            {
                return false;
            }

            var model = _userRespository.GetByEmail(user.Email);
            if (model == null)
            {
                return false;
            }

            if (!model.Password.Equals(user.Password))
            {
                return false;
            }

            model.LastLoginTime = DateTime.Now;
            _userRespository.Update(model);

            return true;
        }
        /// <summary>
        /// 根据Id获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetById(int id)
        {
            return _userRespository.GetById(id);
        }

        /// <summary>
        /// 根据邮箱获取对象
        /// </summary>
        /// <param name="emial"></param>
        /// <returns></returns>
        public User ExistByEmail(string emial)
        {
            return _userRespository.GetByEmail(emial);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<User> GetList()
        {
            return _userRespository.List();
        }
    }
}
