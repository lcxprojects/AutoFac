using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using AutoFac.DBUtility;
using AutoFac.Repository;
using AutoFac.Repository.IRepository;
using AutoFac.Service;
using AutoFac.Service.IService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NetCore.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            // 实例化一个autofac的创建容器
            var builder = new ContainerBuilder();
            ConfigureContainer(builder);

            //services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            //services.AddScoped(typeof(IUserService), typeof(UserService));
            //services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            //批量注册所有仓储Repository && Service
            var assemblies = new Assembly[] { Assembly.Load("AutoFac.Repository"), Assembly.Load("AutoFac.Service") }; //声明一个可变数组，可以加载多个类库
            builder.RegisterAssemblyTypes(assemblies).Where(t => !t.IsAbstract).AsImplementedInterfaces().PropertiesAutowired(); // 获取所有相关类库的程序集

            //注册泛型仓储
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }


    }

    public static class StartUpExtenions
    {
        /// <summary>
        /// 批量注册服务
        /// </summary>
        /// <param name="services">DI服务</param>
        /// <param name="assemblys">需要批量注册的程序集集合</param>
        /// <param name="baseType">基础类/接口</param>
        /// <param name="serviceLifetime">服务生命周期</param>
        /// <returns></returns>
        public static IServiceCollection BatchRegisterService(this IServiceCollection services, Assembly[] assemblys, Type baseType, ServiceLifetime serviceLifetime = ServiceLifetime.Singleton)
        {
            List<Type> typeList = new List<Type>();  //所有符合注册条件的类集合
            foreach (var assembly in assemblys)
            {
                //筛选当前程序集下符合条件的类
                var types = assembly.GetTypes().Where(t => !t.IsInterface && !t.IsSealed && !t.IsAbstract && baseType.IsAssignableFrom(t));
                if (types != null && types.Count() > 0)
                    typeList.AddRange(types);
            }
            if (typeList.Count() == 0)
                return services;

            var typeDic = new Dictionary<Type, Type[]>(); //待注册集合
            foreach (var type in typeList)
            {
                var interfaces = type.GetInterfaces();   //获取接口
                typeDic.Add(type, interfaces);
            }
            if (typeDic.Keys.Count() > 0)
            {
                foreach (var instanceType in typeDic.Keys)
                {
                    foreach (var interfaceType in typeDic[instanceType])
                    {
                        //根据指定的生命周期进行注册
                        switch (serviceLifetime)
                        {
                            case ServiceLifetime.Scoped:
                                services.AddScoped(interfaceType, instanceType);
                                break;
                            case ServiceLifetime.Singleton:
                                services.AddSingleton(interfaceType, instanceType);
                                break;
                            case ServiceLifetime.Transient:
                                services.AddTransient(interfaceType, instanceType);
                                break;
                        }
                    }
                }
            }
            return services;
        }
    }

}
