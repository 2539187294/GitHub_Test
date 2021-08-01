using _02.应用服务.IService;
using _03.领域.Entities;
using _03.领域.IRespository;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02.应用服务.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRespository _roleRespository = null;
        public RoleService(IRoleRespository roleRespository)
        {
            _roleRespository = roleRespository;
        }

        public int Create(Role role)
        {
           return _roleRespository.Create(role);
        }

        public bool Update(Role role)
        {
            return _roleRespository.Update(role);
        }

        public List<Role> GetList()
        {
            return _roleRespository.GetList();
        }

        public Role GetById(int Id)
        {
            return _roleRespository.GetById(Id);
        }

        public Role GetByName(string name)
        {
            return _roleRespository.GetByName(name);
        }

    }
}
