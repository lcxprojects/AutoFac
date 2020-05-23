using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace AutoFac.DBUtility
{
    public class DapperHelper
    {
        private static SqlConnection _sqlConnection = null;
        private static readonly object LockConn = new object();

        public static SqlConnection DbConn
        {
            get
            {
                if (_sqlConnection == null)
                {
                    lock (LockConn)
                    {
                        if (_sqlConnection == null)
                        {
                            var connectionString = ConfigurationManager.ConnectionStrings["DapperSQLConn"].ConnectionString;
                            _sqlConnection = new SqlConnection(connectionString);
                        }
                    }
                }
                return _sqlConnection;
            }
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Add<T>(string sql, T model)
        {
            try
            {
                return DbConn.Execute(sql, model) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
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
            try
            {
                return DbConn.Execute(sql, model) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static bool Update(string sql, string id)
        {
            try
            {
                return DbConn.Execute(sql, new { id = id }) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
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
            try
            {
                return DbConn.Execute(sql, new { id = id }) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
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
            try
            {
                if (para != null)
                    return DbConn.QuerySingle<T>(sql, para);
                else
                    return DbConn.QuerySingle<T>(sql);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
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
            try
            {
                if (para != null)
                    return DbConn.Query<T>(sql, para).ToList();
                else
                    return DbConn.Query<T>(sql).ToList();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        #region  2020年5月21日 14:29:22  引用Dapper.Contrib.Extensions
        /*
         * 需要修改实体
         */
        #endregion

    }
}
