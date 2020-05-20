using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Web.App_Start;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //注册aotofac
            AutofacConfig.Register();

            ////AutofacConfig.Register();
            //var builder = new ContainerBuilder();
            //Assembly controllerAss = Assembly.Load("Web");//类库名称注册 控制器所在的程序项中
            //builder.RegisterAssemblyModules(controllerAss);
            //builder.RegisterControllers(Assembly.GetExecutingAssembly()); //把当前程序集中的controller都进行注册
            //Assembly[] assemblies = new Assembly[] { Assembly.Load("AutoFac.Repository"), Assembly.Load("AutoFac.Service") }; //声明一个可变数组，可以加载多个类库
            //builder.RegisterAssemblyTypes(assemblies).Where(t => !t.IsAbstract).AsImplementedInterfaces().PropertiesAutowired(); // 获取所有相关类库的程序集

            ////创建一个Autofac的容器
            //var container = builder.Build();
            ////将MVC的控制器对象实例 交由autofac来创建
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));



        }

        //抓取全局错误
        protected void Application_Error(Object sender, EventArgs e)
        {
            //在出现未处理的错误时运行的代码         
            Exception objError = Server.GetLastError().GetBaseException();

            lock (this)
            {
                //判断是否要创建SystemLog文件
                var filePath = AppDomain.CurrentDomain.BaseDirectory + @"Log";
                if (!Directory.Exists(filePath))
                    Directory.CreateDirectory(filePath);
                //判断是否要创建txt
                var path = HttpContext.Current.Server.MapPath(@"/Log/" + DateTime.Now.ToString("yyyy-MM-dd") + "错误日志.txt");
                if (!File.Exists(path))
                    File.Create(path).Close();
                using (StreamWriter w = File.AppendText(path))
                {
                    w.WriteLine("\r\n系统发生错误: ");
                    w.WriteLine("发生时间：{0}", DateTime.Now);
                    w.WriteLine("发生异常页：{0}", HttpContext.Current.Request.Url.ToString());
                    w.WriteLine("发生错误的类名：{0}", objError.TargetSite.DeclaringType.FullName);
                    w.WriteLine("发生错误的方法名：{0}", objError.TargetSite.Name);
                    w.WriteLine("异常信息：{0}", objError.Message);
                    w.WriteLine("错误源：{0}", objError.Source);
                    w.WriteLine("堆栈信息：{0}", objError.StackTrace);
                    w.WriteLine("________________________________________________________");
                    w.Flush();
                    w.Close();
                }
            }
            //清除当前异常 使之不返回到请求页面
            Server.ClearError();
            Response.Write("程序出现异常状态，请联系管理员");
        }

    }
}
