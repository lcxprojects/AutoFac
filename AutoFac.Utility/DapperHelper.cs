using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperExtensions;

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
                            //var connectionString = ConfigurationManager.ConnectionStrings["DapperSQLConn"].ConnectionString;
                            var connectionString = "data source=ha.51bc.cc,18433;Database=xmq_xzs;uid=sa;pwd=Aa@123!@#;Max Pool Size = 512;Min Pool Size=1;";
                            _sqlConnection = new SqlConnection(connectionString);
                        }
                    }
                }
                return _sqlConnection;
            }
        }

        public static string GetConnectionString()
        {
            var connString = "";
            try
            {

            }
            catch (Exception e)
            {

            }
            return connString;
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

        /// <summary>
        /// dapper通用分页方法
        /// </summary>
        /// <typeparam name="T">泛型集合实体类</typeparam>
        /// <param name="files">列</param>
        /// <param name="tableName">表</param>
        /// <param name="where">条件</param>
        /// <param name="orderby">排序</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">当前页显示条数</param>
        /// <param name="total">结果集总数</param>
        /// <returns></returns>
        public static List<T> GetPageList<T>(string files, string tableName, string where, string orderby, int pageIndex, int pageSize, out int total)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("SELECT COUNT(1) FROM {0} where {1};", tableName, where);
            sb.AppendFormat(@"SELECT  {0}
                                FROM(SELECT ROW_NUMBER() OVER(ORDER BY {3}) AS RowNum,{0}
                                          FROM  {1}
                                          WHERE {2}
                                        ) AS result
                                WHERE BETWEEN  {4}  AND {5} 
                                ORDER BY {3}", files, tableName, where, orderby, (pageIndex - 1) * pageSize + 1, pageIndex * pageSize);
            using (var reader = DbConn.QueryMultiple(sb.ToString()))
            {
                total = reader.ReadFirst<int>();
                return reader.Read<T>().ToList();
            }
        }


        #region  2020年5月21日 14:29:22  引用DapperExtensions

        public static bool Insert<T>(T model) where T : class
        {
            return DbConn.Insert(model);
        }

        public static bool Update<T>(T model) where T : class
        {
            return DbConn.Update(model);
        }

        public static T Get<T>(object id) where T : class
        {
            return DbConn.Get<T>(id);
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="para"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        public static List<T> GetList<T>(List<IPredicate> para, List<ISort> sort) where T : class
        {
            if (para == null)
                return DbConn.GetList<T>(null, sort).ToList();
            else
                return DbConn.GetList<T>(para, sort).ToList();
        }


        #endregion

    }
}
