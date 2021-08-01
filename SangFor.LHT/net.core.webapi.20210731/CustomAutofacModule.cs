using _02.应用服务.IService;
using _02.应用服务.Service;
using _03.领域.Entities;
using _03.领域.IRespository;
using _04.data.EF;
using _04.data.Respository;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net.core.webapi._20210731
{
    public class CustomAutofacModule : Module
    {
        /// <summary>
        /// AutoFac注册类
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRespository>().As<IUserRespository>();
            builder.RegisterType<RoleRespository>().As<IRoleRespository>();

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<RoleService>().As<IRoleService>();
        }
    }
}
