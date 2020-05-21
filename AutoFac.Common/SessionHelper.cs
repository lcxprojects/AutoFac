using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AutoFac.Common
{
    /// <summary>
    ///  session帮助类
    ///  
    /// ThinkWang
    /// 2014-3-6
    /// </summary>
    public class SessionHelper
    {
        private static string appPrefix = ConfigHelper.Get("AppPrefix");

        #region 添加session
        public static void Set(string key, object value)
        {
            HttpContext.Current.Session.Add(appPrefix + key, value);
        }
        #endregion

        #region 获取session
        public static object Get(string key)
        {
            return HttpContext.Current.Session[appPrefix + key];
        }
        public static T Get<T>(string key)
        {
            object obj = Get(key);
            return obj == null ? default(T) : (T)obj;
        }
        public static object GetAndRemove(string key)
        {
            object obj2 = HttpContext.Current.Session[appPrefix + key];
            if (HttpContext.Current.Session[appPrefix + key] != null)
            {
                HttpContext.Current.Session.Remove(appPrefix + key);
            }
            return obj2;
        }
        public static T GetAndRemove<T>(string key)
        {
            object obj = GetAndRemove(key);
            return obj == null ? default(T) : (T)obj;
        }
        #endregion

        #region 移除session
        public static void Remove(string key)
        {
            if (HttpContext.Current.Session[appPrefix + key] != null)
            {
                HttpContext.Current.Session.Remove(appPrefix + key);
            }
        }

        public static void RemoveAll()
        {
            HttpContext.Current.Session.RemoveAll();
        }
        #endregion

    }
 
}
