using _03.领域.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.领域.DbContexts
{
    public class DbContext
    {
        public static List<User> Users = new List<User>()
        {
            new User(){ Id =1001, Email ="zhangsan@qq.com", Password ="zs1234", userName ="张三", RegTime =DateTime.Now.Date, LastLoginTime =DateTime.Now, Status = true },
            new User(){ Id =1002, Email ="lisi@qq.com", Password ="ls1234", userName ="李四", RegTime =DateTime.Now.Date, LastLoginTime =DateTime.Now, Status = false },
            new User(){ Id =1003, Email ="wangwu@qq.com", Password ="ww1234", userName ="王五", RegTime =DateTime.Now.Date, LastLoginTime =DateTime.Now, Status = true },
            new User(){ Id =1004, Email ="zhaolu@qq.com", Password ="zl1234", userName ="赵六", RegTime =DateTime.Now.Date, LastLoginTime =DateTime.Now, Status = true },
        };

        public static List<Role> Roles = new List<Role>()
        {
            new Role(){ guid = Guid.NewGuid(), Id = 10, Name ="财务组长", RegisterTime = DateTime.Now, RoleType = RoleType.admin, UserId = 1001 },
            new Role(){ guid = Guid.NewGuid(), Id = 11, Name ="财务部门经理", RegisterTime = DateTime.Now, RoleType = RoleType.user, UserId = 1002 },
            new Role(){ guid = Guid.NewGuid(), Id = 12, Name ="财务专员", RegisterTime = DateTime.Now, RoleType = RoleType.vistor, UserId = 1003 },
        };

    }
}
