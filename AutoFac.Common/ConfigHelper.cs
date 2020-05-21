using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.Common
{
    /// <summary>
    /// web.config操作类
    ///
    /// ThinkWang
    /// 2014-3-6
    /// </summary>
    public sealed class ConfigHelper
    {
        /// <summary>
        /// 得到AppSettings中的配置字符串信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Get(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// 得到ConnectionString中的配置连接字符串
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name == "" ? "SQLConnString" : name].ConnectionString;
        }

        /// <summary>
        /// 得到AppSettings中的配置Bool信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool GetBool(string key)
        {
            bool result = false;
            string cfgVal = Get(key);
            bool.TryParse(cfgVal, out result);
            return result;
        }

        /// <summary>
        /// 得到AppSettings中的配置Decimal信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static decimal GetDecimal(string key)
        {
            decimal result = 0;
            string cfgVal = Get(key);
            decimal.TryParse(cfgVal, out result);
            return result;
        }

        /// <summary>
        /// 得到AppSettings中的配置int信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int GetInt(string key)
        {
            int result = 0;
            string cfgVal = Get(key);
            int.TryParse(cfgVal, out result);
            return result;
        }

        public static void Reload()
        {
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// 设置AppSettings中的配置字符串信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static void Set(string key, string value)
        {
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                config.AppSettings.Settings[key].Value = value;

            }
            else
            {
                config.AppSettings.Settings.Add(key, value);
            }

            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// 设置ConnectionString中的配置连接字符串
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static void SetConnectionString(string name, string value)
        {
            var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (ConfigurationManager.ConnectionStrings[name] != null)
            {

                config.ConnectionStrings.ConnectionStrings[name].ConnectionString = value;
            }
            else
            {
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(name, value));
            }

            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

        }
    }
}