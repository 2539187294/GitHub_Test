
using _02.Ӧ�÷���.IService;
using _02.Ӧ�÷���.Service;
using _03.����.Entities;
using _04.data.EF;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net.core.webapi._20210731
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public ILifetimeScope AutofacContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //services.AddControllers();

            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IUserRespository, UserRespository>();

            //services.AddSingleton<IUserService, UserService>();
            //services.AddSingleton<IUserRespository, UserRespository>();

        }

        //autofac ����
        public void ConfigureContainer(ContainerBuilder builder)
        {
            // ֱ����Autofacע�������Զ���� 
            builder.RegisterModule(new CustomAutofacModule());
        }

        //public IServiceProvider ConfigureServices(IServiceCollection services)
        //{
        //    services.AddControllers();
        //    var builder = new ContainerBuilder();
        //    builder.RegisterType<UserRespository>().As<IUserRespository>();
        //    builder.RegisterType<UserService>().As<IUserService>();

        //    builder.Populate(services);
        //    var container = builder.Build();
        //    return new AutofacServiceProvider(container);
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
