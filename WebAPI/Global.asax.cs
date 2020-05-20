using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.WebApi;
using WebAPI.App_Start;

namespace WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //注册aotofac
            AutofacConfig.Register();

            //毙掉XML使api返回为json            
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

        }


        //抓取全局错误
        protected void Application_Error(Object sender, EventArgs e)
        {
            //在出现未处理的错误时运行的代码         
            Exception objError = Server.GetLastError().GetBaseException();

            lock (this)
            {
                //判断是否要创建Log文件
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
