using _03.领域.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.领域.IRespository
{
    public interface IRoleRespository
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int Create(Role role);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        bool Delete(Role role);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        bool Update(Role role);
        /// <summary>
        /// 根据Id获取对象
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Role GetByName(string name);

        /// <summary>
        /// 根据名字获取对象
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Role GetById(int Id);
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        List<Role> GetList();

    }
}
