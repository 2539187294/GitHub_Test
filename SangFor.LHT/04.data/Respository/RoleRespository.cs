using _03.领域.DbContexts;
using _03.领域.Entities;
using _03.领域.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.data.Respository
{
    public class RoleRespository : IRoleRespository
    {
        public int Create(Role role)
        {
            if(role == null)
                throw new NotImplementedException();
            DbContext.Roles.Add(role);
            return 1;
        }

        public bool Delete(Role role)
        {
            if(role == null)
                throw new NotImplementedException();
            var result = DbContext.Roles.Remove(role);
            return result;
        }

        public Role GetByName(string name)
        {
            if(name == null)
                throw new NotImplementedException();
            return DbContext.Roles.Single(x => x.Name == name);
        }

        public Role GetById(int Id)
        {
            if(Id < 0)
                throw new NotImplementedException();
            return  DbContext.Roles.SingleOrDefault(x => x.Id == Id);
        }

        public List<Role> GetList()
        {
            return DbContext.Roles.ToList();
        }

        public bool Update(Role role)
        {
            if(role == null)
                throw new NotImplementedException();
            var model = DbContext.Roles.SingleOrDefault(x => x.Id == role.Id);

            model.Name = role.Name;
            model.RegisterTime = role.RegisterTime;
            model.RoleType = role.RoleType;
            return true;
        }
    }
}
