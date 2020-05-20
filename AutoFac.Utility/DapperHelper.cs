using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AutoFac.DBUtility
{
    public class DapperHelper
    {
        //数据库连接字符串(web.config来配置)
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["DapperSQLConn"].ConnectionString;

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Add<T>(string sql, T model)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    return conn.Execute(sql, model) > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Update<T>(string sql, T model)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    return conn.Execute(sql, model) > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public static bool Update(string sql, string id)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    return conn.Execute(sql, new { id = id }) > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(string sql, string id)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    return conn.Execute(sql, new { id = id }) > 0;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        ///  查询单数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="para">new {id=id}</param>
        /// <returns></returns>
        public static T GetModel<T>(string sql, object para)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    if (para != null)
                        return conn.QuerySingle<T>(sql, para);
                    else
                        return conn.QuerySingle<T>(sql);
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        ///  查询数据列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static List<T> GetModelList<T>(string sql, object para)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    if (para != null)
                        return conn.Query<T>(sql, para).ToList();
                    else
                        return conn.Query<T>(sql).ToList();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }


    }
}
