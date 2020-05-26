using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.ORM
{
    public class DbMasterSession : IDisposable
    {
        bool _disposed;
        /// <summary>
        /// 用于管理数据库连接
        /// </summary>
        public IDbConnection DbConnection { get; set; }

        public DbMasterSession()
        {
            DbConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterConStr"].ConnectionString);
        }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public enum DbType
        {

        }

        /// <summary>
        /// 关闭DbConnection
        /// </summary>
        public void Dispose()
        {
            if (this._disposed)
                return;

            this._disposed = true;

            if (this.DbConnection == null)
                return;

            if (this.DbConnection.State != ConnectionState.Closed)
                this.DbConnection.Close();
        }
    }
}
