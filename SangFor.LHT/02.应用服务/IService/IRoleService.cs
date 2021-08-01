using _03.领域.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02.应用服务.IService
{
    public interface IRoleService
    {
        int Create(Role role);

        bool Update(Role role);

        List<Role> GetList();

        Role GetById(int Id);

        Role GetByName(string name);
    }
}
