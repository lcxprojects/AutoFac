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
            // ʵ����һ��autofac�Ĵ�������
            var builder = new ContainerBuilder();
            ConfigureContainer(builder);

            //services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            //services.AddScoped(typeof(IUserService), typeof(UserService));
            //services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            //����ע�����вִ�Repository && Service
            var assemblies = new Assembly[] { Assembly.Load("AutoFac.Repository"), Assembly.Load("AutoFac.Service") }; //����һ���ɱ����飬���Լ��ض�����
            builder.RegisterAssemblyTypes(assemblies).Where(t => !t.IsAbstract).AsImplementedInterfaces().PropertiesAutowired(); // ��ȡ����������ĳ���

            //ע�᷺�Ͳִ�
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
        /// ����ע�����
        /// </summary>
        /// <param name="services">DI����</param>
        /// <param name="assemblys">��Ҫ����ע��ĳ��򼯼���</param>
        /// <param name="baseType">������/�ӿ�</param>
        /// <param name="serviceLifetime">������������</param>
        /// <returns></returns>
        public static IServiceCollection BatchRegisterService(this IServiceCollection services, Assembly[] assemblys, Type baseType, ServiceLifetime serviceLifetime = ServiceLifetime.Singleton)
        {
            List<Type> typeList = new List<Type>();  //���з���ע���������༯��
            foreach (var assembly in assemblys)
            {
                //ɸѡ��ǰ�����·�����������
                var types = assembly.GetTypes().Where(t => !t.IsInterface && !t.IsSealed && !t.IsAbstract && baseType.IsAssignableFrom(t));
                if (types != null && types.Count() > 0)
                    typeList.AddRange(types);
            }
            if (typeList.Count() == 0)
                return services;

            var typeDic = new Dictionary<Type, Type[]>(); //��ע�Ἧ��
            foreach (var type in typeList)
            {
                var interfaces = type.GetInterfaces();   //��ȡ�ӿ�
                typeDic.Add(type, interfaces);
            }
            if (typeDic.Keys.Count() > 0)
            {
                foreach (var instanceType in typeDic.Keys)
                {
                    foreach (var interfaceType in typeDic[instanceType])
                    {
                        //����ָ�����������ڽ���ע��
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
