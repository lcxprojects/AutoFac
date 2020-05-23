using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using AutoFac.Repository;
using AutoFac.Repository.IRepository;
using AutoFac.Service;
using AutoFac.Service.IService;

namespace Web.App_Start
{
    public class AutofacConfig
    {
        /// <summary>
        /// 负责调用autofac框架实现业务逻辑层和数据仓储层程序及中的类型对象的创建
        /// 负责创建Web控制器类的对象（调用控制器中的有参构造函数）,接管DefaultControllerFactory的工作
        /// </summary>

        public static void Register()

        {

            // 实例化一个autofac的创建容器

            var builder = new ContainerBuilder();

            SetupResolveRules(builder);

            //注册所有的Controllers

            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();

            // 创建一个autofac的容器

            var container = builder.Build();

            // 控制器对象由autofac来创建

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }



        /// <summary>
        /// 设置配置规则
        /// </summary>
        /// <param name="builder"></param>

        public static void SetupResolveRules(ContainerBuilder builder)

        {
            //注册Controller

            // 告诉autofac框架，将来要创建的控制器类存放在哪个程序集
            var controllerAssmbly = Assembly.Load("Web");
            builder.RegisterControllers(controllerAssmbly);

            //批量注册所有仓储Repository && Service
            var assemblies = new Assembly[] { Assembly.Load("AutoFac.Repository"), Assembly.Load("AutoFac.Service") }; //声明一个可变数组，可以加载多个类库
            builder.RegisterAssemblyTypes(assemblies).Where(t => !t.IsAbstract).AsImplementedInterfaces().PropertiesAutowired(); // 获取所有相关类库的程序集

            //注册泛型仓储
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>));
            //builder.RegisterGeneric(typeof(BaseService<>)).As(typeof(IBaseService<>));

            //注册log模块
            //builder.RegisterModule(new LoggingModule());

        }

    }
}