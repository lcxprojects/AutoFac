using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.DBUtility
{
    /// <summary>
    /// 数据访问抽象基础类
    /// Copyright (C) Maticsoft 
    /// </summary>
    public abstract class DbHelperSQL
    {
        //数据库连接字符串(web.config来配置)，多数据库可使用DbHelperSQLP来实现.
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["OzyLive"].ConnectionString;
        public DbHelperSQL()
        {
        }

        #region 公用方法
        /// <summary>
        /// 判断是否存在某表的某个字段
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="columnName">列名称</param>
        /// <returns>是否存在</returns>
        public static bool ColumnExists(string tableName, string columnName)
        {
            string sql = "select count(1) from syscolumns where [id]=object_id('" + tableName + "') and [name]='" + columnName + "'";
            object res = GetSingle(sql);
            if (res == null)
            {
                return false;
            }
            return Convert.ToInt32(res) > 0;
        }
        //获取排序或主键
        public static int GetMaxID(string fieldName, string tableName)
        {
            int num = 0;
            string strsql = "select max(" + fieldName + ")+1 from " + tableName + " where IsDel=0";
            object obj = GetSingle(strsql);
            if (fieldName == "sort")
            {
                if (obj == null)
                {
                    return 0;
                }
                else
                {
                    num = int.Parse(obj.ToString());
                }
            }
            else
            {
                if (obj == null)
                {
                    return 1;
                }
                else
                {
                    num = int.Parse(obj.ToString());
                }
            }
            return num;
        }



        public static int GetMaxTypeSort(string fieldName, string tableName, string strWhere)
        {
            int num = 0;
            string strsql = "select max(" + fieldName + ")+1 from " + tableName + " where IsDel=0 " + strWhere;
            object obj = DbHelperSQL.GetSingle(strsql);
            if (fieldName == "sort")
            {
                if (obj == null)
                {
                    return 0;
                }
                else
                {
                    num = int.Parse(obj.ToString()) + 1;
                }
            }
            else
            {
                if (obj == null)
                {
                    return 1;
                }
                else
                {
                    num = int.Parse(obj.ToString());
                }
            }
            return num;
        }


        public static bool Exists(string strSql)
        {
            object obj = GetSingle(strSql);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString()); //也可能=0
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 表是否存在
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public static bool TabExists(string TableName)
        {
            string strsql = "select count(*) from sysobjects where id = object_id(N'[" + TableName + "]') and OBJECTPROPERTY(id, N'IsUserTable') = 1";
            //string strsql = "SELECT count(*) FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[" + TableName + "]') AND type in (N'U')";
            object obj = GetSingle(strsql);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool Exists(string strSql, params SqlParameter[] cmdParms)
        {
            object obj = GetSingle(strSql, cmdParms);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region  执行简单SQL语句

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行Sql和Oracle滴混合事务
        /// </summary>
        /// <param name="list">SQL命令行列表</param>
        /// <param name="oracleCmdSqlList">Oracle命令行列表</param>
        /// <returns>执行结果 0-由于SQL造成事务失败 -1 由于Oracle造成事务失败 1-整体事务执行成功</returns>
        public static int ExecuteSqlTran(List<CommandInfo> list, List<CommandInfo> oracleCmdSqlList)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    foreach (CommandInfo myDE in list)
                    {
                        string cmdText = myDE.CommandText;
                        SqlParameter[] cmdParms = (SqlParameter[])myDE.Parameters;
                        PrepareCommand(cmd, conn, tx, cmdText, cmdParms);
                        if (myDE.EffentNextType == EffentNextType.SolicitationEvent)
                        {
                            if (myDE.CommandText.ToLower().IndexOf("count(") == -1)
                            {
                                tx.Rollback();
                                throw new Exception("违背要求" + myDE.CommandText + "必须符合select count(..的格式");
                                //return 0;
                            }

                            object obj = cmd.ExecuteScalar();
                            bool isHave = false;
                            if (obj == null && obj == DBNull.Value)
                            {
                                isHave = false;
                            }
                            isHave = Convert.ToInt32(obj) > 0;
                            if (isHave)
                            {
                                //引发事件
                                myDE.OnSolicitationEvent();
                            }
                        }
                        if (myDE.EffentNextType == EffentNextType.WhenHaveContine || myDE.EffentNextType == EffentNextType.WhenNoHaveContine)
                        {
                            if (myDE.CommandText.ToLower().IndexOf("count(") == -1)
                            {
                                tx.Rollback();
                                throw new Exception("SQL:违背要求" + myDE.CommandText + "必须符合select count(..的格式");
                                //return 0;
                            }

                            object obj = cmd.ExecuteScalar();
                            bool isHave = false;
                            if (obj == null && obj == DBNull.Value)
                            {
                                isHave = false;
                            }
                            isHave = Convert.ToInt32(obj) > 0;

                            if (myDE.EffentNextType == EffentNextType.WhenHaveContine && !isHave)
                            {
                                tx.Rollback();
                                throw new Exception("SQL:违背要求" + myDE.CommandText + "返回值必须大于0");
                                //return 0;
                            }
                            if (myDE.EffentNextType == EffentNextType.WhenNoHaveContine && isHave)
                            {
                                tx.Rollback();
                                throw new Exception("SQL:违背要求" + myDE.CommandText + "返回值必须等于0");
                                //return 0;
                            }
                            continue;
                        }
                        int val = cmd.ExecuteNonQuery();
                        if (myDE.EffentNextType == EffentNextType.ExcuteEffectRows && val == 0)
                        {
                            tx.Rollback();
                            throw new Exception("SQL:违背要求" + myDE.CommandText + "必须有影响行");
                            //return 0;
                        }
                        cmd.Parameters.Clear();
                    }
                    //string oraConnectionString = PubConstant.GetConnectionString("ConnectionStringPPC");
                    //bool res = OracleHelper.ExecuteSqlTran(oraConnectionString, oracleCmdSqlList);
                    //if (!res)
                    //{
                    //    tx.Rollback();
                    //    throw new Exception("Oracle执行失败");
                    //    // return -1;
                    //}
                    tx.Commit();
                    return 1;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    tx.Rollback();
                    throw e;
                }
                catch (Exception e)
                {
                    tx.Rollback();
                    throw e;
                }
            }
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>        
        public static int ExecuteSqlTran(List<String> SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    int count = 0;
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return count;
                }
                catch
                {
                    tx.Rollback();
                    return 0;
                }
            }
        }
        /// <summary>
        /// 执行带一个存储过程参数的的SQL语句。
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <param name="content">参数内容,比如一个字段是格式复杂的文章，有特殊符号，可以通过这个方式添加</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString, string content)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(SQLString, connection);
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@content", SqlDbType.NText);
                myParameter.Value = content;
                cmd.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    throw e;
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// 执行带一个存储过程参数的的SQL语句。
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <param name="content">参数内容,比如一个字段是格式复杂的文章，有特殊符号，可以通过这个方式添加</param>
        /// <returns>影响的记录数</returns>
        public static object ExecuteSqlGet(string SQLString, string content)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(SQLString, connection);
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@content", SqlDbType.NText);
                myParameter.Value = content;
                cmd.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    object obj = cmd.ExecuteScalar();
                    if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                    {
                        return null;
                    }
                    else
                    {
                        return obj;
                    }
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    throw e;
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// 向数据库里插入图像格式的字段(和上面情况类似的另一种实例)
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="fs">图像字节,数据库的字段类型为image的情况</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSqlInsertImg(string strSQL, byte[] fs)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(strSQL, connection);
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@fs", SqlDbType.Image);
                myParameter.Value = fs;
                cmd.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    throw e;
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object GetSingle(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }
        public static object GetSingle(string SQLString, int Times)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.CommandTimeout = Times;
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw e;
                    }
                }
            }
        }
        /// <summary>
        /// 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string strSQL)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(strSQL, connection);
            try
            {
                connection.Open();
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return myReader;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw e;
            }

        }
        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }
        public static DataSet Query(string SQLString, int Times)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.SelectCommand.CommandTimeout = Times;
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }



        #endregion

        #region 执行带参数的SQL语句

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }
        public static int ExecuteSqlList(string SQLString, List<SqlParameter[]> cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommandList(cmd, connection, null, SQLString, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SqlParameter[]）</param>
        public static bool ExecuteSqlTran(Hashtable SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    SqlCommand cmd = new SqlCommand();
                    try
                    {
                        //循环
                        foreach (DictionaryEntry myDE in SQLStringList)
                        {
                            string cmdText = myDE.Key.ToString();
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Value;
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            int val = cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SqlParameter[]）</param>
        public static int ExecuteSqlTran(System.Collections.Generic.List<CommandInfo> cmdList)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    SqlCommand cmd = new SqlCommand();
                    try
                    {
                        int count = 0;
                        //循环
                        foreach (CommandInfo myDE in cmdList)
                        {
                            string cmdText = myDE.CommandText;
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Parameters;
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);

                            if (myDE.EffentNextType == EffentNextType.WhenHaveContine || myDE.EffentNextType == EffentNextType.WhenNoHaveContine)
                            {
                                if (myDE.CommandText.ToLower().IndexOf("count(") == -1)
                                {
                                    trans.Rollback();
                                    return 0;
                                }

                                object obj = cmd.ExecuteScalar();
                                bool isHave = false;
                                if (obj == null && obj == DBNull.Value)
                                {
                                    isHave = false;
                                }
                                isHave = Convert.ToInt32(obj) > 0;

                                if (myDE.EffentNextType == EffentNextType.WhenHaveContine && !isHave)
                                {
                                    trans.Rollback();
                                    return 0;
                                }
                                if (myDE.EffentNextType == EffentNextType.WhenNoHaveContine && isHave)
                                {
                                    trans.Rollback();
                                    return 0;
                                }
                                continue;
                            }
                            int val = cmd.ExecuteNonQuery();
                            count += val;
                            if (myDE.EffentNextType == EffentNextType.ExcuteEffectRows && val == 0)
                            {
                                trans.Rollback();
                                return 0;
                            }
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                        return count;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SqlParameter[]）</param>
        public static void ExecuteSqlTranWithIndentity(System.Collections.Generic.List<CommandInfo> SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    SqlCommand cmd = new SqlCommand();
                    try
                    {
                        int indentity = 0;
                        //循环
                        foreach (CommandInfo myDE in SQLStringList)
                        {
                            string cmdText = myDE.CommandText;
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Parameters;
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.InputOutput)
                                {
                                    q.Value = indentity;
                                }
                            }
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            int val = cmd.ExecuteNonQuery();
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.Output)
                                {
                                    indentity = Convert.ToInt32(q.Value);
                                }
                            }
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的SqlParameter[]）</param>
        public static void ExecuteSqlTranWithIndentity(Hashtable SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    SqlCommand cmd = new SqlCommand();
                    try
                    {
                        int indentity = 0;
                        //循环
                        foreach (DictionaryEntry myDE in SQLStringList)
                        {
                            string cmdText = myDE.Key.ToString();
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Value;
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.InputOutput)
                                {
                                    q.Value = indentity;
                                }
                            }
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            int val = cmd.ExecuteNonQuery();
                            foreach (SqlParameter q in cmdParms)
                            {
                                if (q.Direction == ParameterDirection.Output)
                                {
                                    indentity = Convert.ToInt32(q.Value);
                                }
                            }
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public static object GetSingle(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        /// 执行查询语句，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="strSQL">查询语句</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string SQLString, params SqlParameter[] cmdParms)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return myReader;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw e;
            }
            //            finally
            //            {
            //                cmd.Dispose();
            //                connection.Close();
            //            }    

        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }
        }


        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
            }
            catch { conn.Open(); }
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {


                foreach (SqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }


        private static void PrepareCommandList(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, List<SqlParameter[]> cmdParms)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
            }
            catch { conn.Open(); }
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms.Count != 0)
            {
                foreach (var item in cmdParms)
                {
                    if (item != null)
                    {
                        foreach (SqlParameter parameter in item)
                        {
                            if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                                (parameter.Value == null))
                            {
                                parameter.Value = DBNull.Value;
                            }
                            cmd.Parameters.Add(parameter);
                        }
                    }


                }
            }
        }
        #endregion

        #region 存储过程操作

        /// <summary>
        /// 执行存储过程，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataReader returnReader;
            connection.Open();
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;
            returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return returnReader;

        }


        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                try
                {

                    sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                    sqlDA.Fill(dataSet, tableName);
                }
                catch (Exception e)
                {

                    throw e;
                }
                connection.Close();
                return dataSet;
            }
        }
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName, int Times)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                sqlDA.SelectCommand.CommandTimeout = Times;
                sqlDA.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }


        /// <summary>
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                if (parameter != null)
                {
                    // 检查未分配值的输出参数,将其分配以DBNull.Value.
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    command.Parameters.Add(parameter);
                }
            }

            return command;
        }

        /// <summary>
        /// 执行存储过程，返回影响的行数        
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="rowsAffected">影响的行数</param>
        /// <returns></returns>
        public static int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int result;
                connection.Open();
                SqlCommand command = BuildIntCommand(connection, storedProcName, parameters);
                rowsAffected = command.ExecuteNonQuery();
                result = (int)command.Parameters["ReturnValue"].Value;
                //Connection.Close();
                return result;
            }
        }

        /// <summary>
        /// 创建 SqlCommand 对象实例(用来返回一个整数值)    
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand 对象实例</returns>
        private static SqlCommand BuildIntCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.Parameters.Add(new SqlParameter("ReturnValue",
                SqlDbType.Int, 4, ParameterDirection.ReturnValue,
                false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }
        #endregion

        #region >>删除<<
        /// <summary>
        /// 执行删除
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="keyValue">主键值</param>
        /// <param name="keyName">主键字段名称</param>
        /// <returns>删除结果</returns>
        public static int Delete(string table, string keyValue, string keyName = "Id")
        {
            string sql = string.Format("DELETE FROM {0} WHERE {1}=@Id", table, keyName);
            var args = new ArrayList() { new SqlParameter("@Id", keyValue) };
            return ExecuteSql(sql, args);
        }

        /// <summary>
        /// 根据查询条件删除
        /// </summary>
        /// <param name="table"></param>
        /// <param name="htCondition"></param>
        /// <returns></returns>
        public static int Delete(string table, Hashtable htCondition)
        {
            ArrayList args;
            string conditionStr = GetConditionString(htCondition, out args);
            string sql = string.Format("DELETE FROM {0} WHERE 1=1{1}", table, conditionStr);
            return ExecuteSql(sql, args);
        }
        #endregion

        #region >>新增<<
        /// <summary>
        /// 执行插入
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="htFilds">字段和值</param>
        /// <returns>结果</returns>
        public static int Insert(string table, Hashtable htField)
        {
            ArrayList args;
            string sql = GetInsertSql(table, htField, out args);

            return ExecuteSql(sql, args);
        }

        /// <summary>
        /// 执行插入，返回ID
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="htField">字段和值</param>
        /// <param name="keyValue">ID</param>
        public static void Insert(string table, Hashtable htField, out string keyValue)
        {
            ArrayList args;
            string sql = string.Format("{0};SELECT @@IDENTITY", GetInsertSql(table, htField, out args));

            keyValue = Convert.ToString(ExecuteScalar(sql, args));
        }
        /// <summary>
        /// 使用DataTable插入数据
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public static int Insert(DataTable dt, string table = "")
        {
            if (table == "")
            {
                table = dt.TableName;
            }
            int r = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Hashtable htField = new Hashtable();
                foreach (DataColumn dc in dt.Columns)
                {
                    htField.Add(dc.ColumnName, dr[dc.ColumnName]);
                }
                r += Insert(table, htField);
            }
            return r;
        }
        /// <summary>
        /// 使用DataTable插入数据，只适合插入一条
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="keyValue">返回主键</param>
        /// <param name="table"></param>
        public static void Insert(DataTable dt, out string keyValue, string table = "")
        {
            keyValue = "";
            if (table == "")
            {
                table = dt.TableName;
            }

            foreach (DataRow dr in dt.Rows)
            {
                Hashtable htField = new Hashtable();
                foreach (DataColumn dc in dt.Columns)
                {
                    htField.Add(dc.ColumnName, dr[dc.ColumnName]);
                }
                Insert(table, htField, out keyValue);
            }
        }
        /// <summary>
        /// 获取插入语句Sql
        /// </summary>
        /// <param name="table"></param>
        /// <param name="htField"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private static string GetInsertSql(string table, Hashtable htField, out ArrayList args)
        {
            args = new ArrayList();
            var sbField = new StringBuilder();
            var sbValue = new StringBuilder();

            foreach (DictionaryEntry de in htField)
            {
                // 参数集合
                args.Add(new SqlParameter(de.Key.ToString(), de.Value));
                // 字段和值
                sbField.AppendFormat("[{0}],", de.Key.ToString());
                sbValue.AppendFormat("@{0},", de.Key.ToString());
            }

            return string.Format
            (
                "INSERT INTO {0}({1})VALUES({2});",
                table,
                sbField.ToString().TrimEnd(','),
                sbValue.ToString().TrimEnd(',')
            );
        }

        #endregion

        #region >>更新<<
        /// <summary>
        /// 执行更新
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="htField">字段和值</param>
        /// <param name="keyValue">主键值</param>
        /// <param name="keyName">主键字段名称</param>
        /// <returns>结果</returns>
        public static int Update(string table, Hashtable htField, string keyValue, string keyName = "Id")
        {
            var args = new ArrayList();
            var sbField = new StringBuilder();

            foreach (DictionaryEntry de in htField)
            {
                // 参数集合
                args.Add(new SqlParameter(de.Key.ToString(), de.Value));
                // 要更新的字段
                sbField.AppendFormat("{0}=@{0},", de.Key);
            }

            // 添加ID
            args.Add(new SqlParameter(keyName, keyValue));

            string sql = string.Format("UPDATE {0} SET {1} WHERE {2}=@{2} ", table, sbField.ToString().TrimEnd(','), keyName);

            return ExecuteSql(sql, args);

        }

        /// <summary>
        /// 执行更新
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="htField">字段和值</param>
        /// <param name="htCondition">查询条件</param>
        /// <returns></returns>
        public static int Update(string table, Hashtable htField, Hashtable htCondition)
        {
            // 更新字段和值
            ArrayList args;
            var sbField = new StringBuilder();

            // 查询字段和值
            string condition = GetConditionString(htCondition, out args);

            foreach (DictionaryEntry de in htField)
            {
                // 参数集合
                args.Add(new SqlParameter("@AutoKey_" + de.Key, de.Value));
                // 要更新的字段
                sbField.AppendFormat("{0}=@AutoKey_{0},", de.Key);
            }

            // 拼接查询结果
            string sql = string.Format
            (
                "UPDATE {0} SET {1} WHERE 1=1{2}",
                table,
                sbField.ToString().TrimEnd(','),
                condition
            );

            return ExecuteSql(sql, args);

        }
        /// <summary>
        /// 执行更新
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="htField">字段和值</param>
        /// <param name="htCondition">查询条件</param>
        /// <returns></returns>
        public static int Update(string table, Hashtable htField, string condition)
        {
            // 更新字段和值
            ArrayList args = new ArrayList();
            var sbField = new StringBuilder();

            // 查询字段和值
            //string condition = GetConditionString(htCondition, out args);

            foreach (DictionaryEntry de in htField)
            {
                // 参数集合
                args.Add(new SqlParameter(de.Key.ToString(), de.Value));
                // 要更新的字段
                sbField.AppendFormat("{0}=@{0},", de.Key);
            }

            // 拼接查询结果
            string sql = string.Format
            (
                "UPDATE {0} SET {1} WHERE 1=1 AND {2}",
                table,
                sbField.ToString().TrimEnd(','),
                condition
            );

            return ExecuteSql(sql, args);

        }
        public static int Update(DataTable dt, string keyName, string keyValue, string table = "")
        {
            int num = 0;
            if (table == "")
            {
                table = dt.TableName;
            }
            string condition = keyName + "='" + keyValue + "'";
            foreach (DataRow dr in dt.Rows)
            {
                Hashtable htField = new Hashtable();
                foreach (DataColumn dc in dt.Columns)
                {
                    htField.Add(dc.ColumnName, dr[dc.ColumnName]);
                }
                num += Update(table, htField, condition);
            }
            return num;
        }
        #endregion

        #region >>获取单个字段的值<<
        /// <summary>
        /// 获取单个字段值
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="field">字段名</param>
        /// <param name="keyValue">主键值</param>
        /// <param name="keyName">主键字段名称</param>
        /// <returns></returns>
        public static string GetFieldValue(string table, string field, string keyValue, string keyName = "Id")
        {
            // 执行查询
            var args = new ArrayList { new SqlParameter(keyName, keyValue) };
            var sql = string.Format("SELECT {0} FROM {1} WHERE {2}=@{2}", field, table, keyName);

            // 执行查询
            var result = ExecuteScalar(sql, args);

            // 没有查到任何结果
            if (result == null) return null;

            // 如果结果中包含多表连接查询，去除(.)，如(a.Name)去除(a.)
            return result.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="field"></param>
        /// <param name="htCondition"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public static string GetFieldValue(string table, string field, Hashtable htCondition, string order)
        {
            // 查询条件和参数
            ArrayList args;
            var sql = string.Format("SELECT {0} FROM {1} WHERE 1=1{2}", field, table, GetConditionString(htCondition, out args));

            // 查询条件
            if (!string.IsNullOrEmpty(order)) sql += " " + order;

            // 执行查询
            object result = ExecuteScalar(sql, args);

            if (result == null) return null;

            return result.ToString();
        }
        #endregion

        #region >>获取记录数量<<
        /// <summary>
        /// 获取记录数量
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="htCondtion">查询条件</param>
        /// <returns></returns>
        public static int GetRecordCount(string table, Hashtable htCondition)
        {
            // 查询条件和参数
            ArrayList args;
            string sql = string.Format("SELECT COUNT(*) FROM {0} WHERE 1=1{1}", table, GetConditionString(htCondition, out args));

            // 执行查询
            return Convert.ToInt32(ExecuteScalar(sql, args));
        }
        #endregion

        #region >>判断是否存在<<
        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="htCondtion">查询条件</param>
        /// <returns></returns>
        public static bool Exists(string table, Hashtable htCondition)
        {
            // 查询条件和参数
            ArrayList args;
            string sql = string.Format("SELECT COUNT(*) FROM {0} WHERE 1=1{1}", table, GetConditionString(htCondition, out args));

            // 执行查询
            object result = ExecuteScalar(sql, args);

            // 返回结果
            if (result == null) { return false; }
            if (result.ToString() == "0") { return false; }
            return true;
        }

        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="keyValue">主键值</param>
        /// <param name="keyName">主键字段名称</param>
        /// <returns></returns>
        public static bool Exists(string table, string keyValue, string keyName = "Id")
        {
            var args = new ArrayList { new SqlParameter(keyName, keyValue) };
            string sql = string.Format("SELECT COUNT(*) FROM {0} WHERE {1}=@{1}", table, keyName);

            object result = ExecuteScalar(sql, args);

            if (result == null) { return false; }
            if (result.ToString() == "0") { return false; }
            return true;
        }
        #endregion

        #region >>获取查询条件字符串<<
        /// <summary>
        /// 获取查询条件字符串
        /// </summary>
        /// <param name="htCondition">查询条件</param>
        /// <param name="args">参数集合</param>
        /// <returns></returns>
        public static string GetConditionString(Hashtable htCondition, out ArrayList args)
        {
            args = new ArrayList();
            var sbCondition = new StringBuilder();

            // 拼接查询条件
            foreach (DictionaryEntry de in htCondition)
            {
                if (de.Key.ToString().IndexOf(' ') != -1)
                {
                    sbCondition.AppendFormat(" AND {0}", de.Key);
                    if (de.Value != null && !string.IsNullOrWhiteSpace(de.Value.ToString()))
                    {
                        args.Add(de.Value as SqlParameter);
                    }
                    continue;
                }

                sbCondition.AppendFormat(" AND {0}=@{0}", de.Key);
                args.Add(new SqlParameter(de.Key.ToString(), de.Value));
            }

            // 返回查询条件字符串
            return sbCondition.ToString();
        }
        #endregion

        #region >>多表查询<<
        /// <summary>
        /// 多表查询 - 通过ID获取
        /// </summary>
        /// <param name="field">要查询的字段，如：* | Id,Field</param>
        /// <param name="table">表名</param>
        /// <param name="keyValue">主键值</param>
        /// <param name="keyName">主键字段名称</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string field, string table, string keyValue, string keyName = "Id")
        {
            ArrayList args = new ArrayList() { new SqlParameter(keyName, keyValue) };
            string sql = string.Format("SELECT {0} FROM {1} WHERE {2}=@{2}", field, table, keyName);
            return GetDataTable(sql, args);
        }

        /// <summary>
        /// 多表查询 - 通过传入where 字符串 条件 来查询
        /// </summary>
        /// <param name="field">要查询的字段，如：* | Id,Field</param>
        /// <param name="table">表名</param>
        /// <param name="strWhere">查询条件 多个条件注意用and拼接</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string field, string table, string strWhere)
        {
            string sql = string.Format("SELECT {0} FROM {1} {2}", field, table, strWhere);
            return GetDataTable(sql);
        }

        /// <summary>
        /// 多表查询 - 通过查询条件获取
        /// </summary>
        /// <param name="field">查询字段，如： A.Field, B.Field</param>
        /// <param name="table">表名，如： TableOne as A, TableTwo as B</param>
        /// <param name="htCondition">查询条件</param>
        ///  <param name="order">排序,包括字段及排序方式(如：ordernum desc),也可以用""不排序</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string field, string table, Hashtable htCondition, string order)
        {
            ArrayList args;
            string condition = GetConditionString(htCondition, out args);

            string sql = string.Format("SELECT {0} FROM {1} WHERE 1=1 {2}{3}", field, table, condition,
                string.IsNullOrWhiteSpace(order) ? "" : " ORDER BY " + order);

            return GetDataTable(sql, args);
        }

        /// <summary>
        /// 多表分组查询 - 通过查询条件获取
        /// </summary>
        /// <param name="field">查询字段，如： A.Field, B.Field</param>
        /// <param name="table">表名，如： TableOne as A, TableTwo as B</param>
        /// <param name="htCondition">查询条件</param>
        ///  <param name="order">排序,包括字段及排序方式(如：ordernum desc),也可以用""不排序</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string field, string table, Hashtable htCondition, string group, string order, bool IsAddNumber = false)
        {
            ArrayList args;
            string condition = GetConditionString(htCondition, out args);

            string sql = string.Format("SELECT {0} FROM {1} WHERE 1=1 {2} {3} {4}",
                field, table, condition,
                string.IsNullOrWhiteSpace(group) ? "" : " group by " + group,
                string.IsNullOrWhiteSpace(order) ? "" : order);
            if (IsAddNumber)
            {
                sql = string.Format("SELECT {0} FROM {1} WHERE 1=1 {2} {3}",
                field, table, condition,
                string.IsNullOrWhiteSpace(group) ? "" : " group by " + group);
                sql = string.Format("SELECT ROW_NUMBER() OVER({0}) AS '序号',mydata.* FROM ({1}) mydata {0}", order, sql);
            }
            return GetDataTable(sql, args);
        }

        /// <summary>
        /// 多表查询 - 分页
        /// </summary>
        /// <param name="keyName">主键字段</param>
        /// <param name="field">要查询的字段，如：* | Id,Field</param>
        /// <param name="table">表名</param>
        /// <param name="htCondition">条件字符串</param>
        /// <param name="order">排序，包括排序字段和排序方式(如：id desc)</param>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页显示行数</param>
        /// <param name="recordCount">总行数</param>
        /// <param name="pageCount">总共页码数</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string keyName, string field, string table, Hashtable htCondition, string order, int pageIndex, int pageSize, out int recordCount, out int pageCount)
        {
            ArrayList args;
            string condition = GetConditionString(htCondition, out args);

            return GetPageNavigateDataTable(keyName, field, table, condition, order, args, pageIndex, pageSize, out recordCount, out pageCount);

        }

        /// <summary>
        /// 多表查询 - 通过存储过程获取
        /// </summary>
        /// <param name="procName">存储过程</param>
        /// <param name="htCondition">查询条件</param>
        /// <returns></returns>
        public static DataTable GetDataTableByProcName(string procName, Hashtable htCondition)
        {
            ArrayList args;
            string condition = GetConditionString(htCondition, out args);

            return ExecuteProcedureToDt(procName, args);
        }
        #endregion

        #region >>执行SQL语句<<


        /// <summary>
        /// 执行SQL语句,返回受影响的行数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        public static int ExecuteSql(string sql, ArrayList args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        int result = 0;
                        connection.Open();
                        cmd.Parameters.AddRange(args.ToArray());
                        result = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region >>执行查询返回单个对象<<
        /// <summary>
        /// 执行查询返回单个对象
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = cmd.ExecuteScalar();
                        if (Object.Equals(obj, null) || Object.Equals(obj, System.DBNull.Value)) { return null; } else { return obj; }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }

        }

        /// <summary>
        /// 执行查询返回单个对象
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="arg">参数</param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, ArrayList args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.Parameters.AddRange(args.ToArray());
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if (Object.Equals(obj, null) || Object.Equals(obj, System.DBNull.Value)) { return null; } else { return obj; }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }

        }
        #endregion

        #region >>执行存储过程<<
        /// <summary>
        /// 执行存储过程,返回单个对象
        /// </summary>
        /// <param name="procName">存储过程名称</param>
        /// <param name="args">参数</param>
        /// <returns>单个结果</returns>
        public static object ExecuteProcedure(string procName, ArrayList args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(procName, connection))
                {
                    try
                    {

                        connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(args.ToArray());
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if (Object.Equals(obj, null) || Object.Equals(obj, System.DBNull.Value)) { return null; }
                        return obj;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 执行存储过程,返回DataTable
        /// </summary>
        /// <param name="procName">存储过程名称</param>
        /// <param name="args">参数</param>
        /// <returns></returns>
        public static DataTable ExecuteProcedureToDt(string procName, ArrayList args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(procName, connection))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        var adapter = new SqlDataAdapter(cmd);
                        adapter.SelectCommand.Parameters.AddRange(args.ToArray());
                        adapter.Fill(dt);
                        adapter.SelectCommand.Parameters.Clear();
                        return dt;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region >>执行查询获取DataTable<<
        /// <summary>
        /// 执行SQL语句 返回DataTable
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>DataTable</returns>
        public static DataTable GetDataTable(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    var dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 执行SQL语句 返回DataTable
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <param name="args">参数集合</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, ArrayList args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.SelectCommand.Parameters.AddRange(args.ToArray());
                        adapter.Fill(dt);
                        adapter.SelectCommand.Parameters.Clear();
                        return dt;
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 多表查询 - 分页
        /// </summary>
        /// <param name="keyName">主键字段</param>
        /// <param name="field">要查询的字段，如：* | Id,Field</param>
        /// <param name="table">表名</param>
        /// <param name="htCondition">条件字符串</param>
        /// <param name="order">排序，包括排序字段和排序方式(如：id desc)</param>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页显示行数</param>
        /// <param name="recordCount">总行数</param>
        /// <param name="pageCount">总共页码数</param>
        /// <returns></returns>
        public static DataTable GetPageNavigateDataTable(string keyName, string field, string table, string condition,
            string order, ArrayList args, int pageIndex, int pageSize, out int recordCount, out int pageCount)
        {
            // 获取记录数
            string sql = string.Format("SELECT COUNT (1) FROM {0} WHERE 1=1{1}", table, condition);
            recordCount = (int)ExecuteScalar(sql, args);

            // 获取页数
            pageCount = recordCount % pageSize == 0 ? recordCount / pageSize : recordCount / pageSize + 1;

            // 显示当前页的范围，下面两行上下顺序不可颠倒，如果颠倒，记录为0时会出现 负值
            if (pageIndex > pageCount) pageIndex = pageCount;
            if (pageIndex < 1) pageIndex = 1;

            // 判断排序参数order是否为空
            order = string.IsNullOrWhiteSpace(order) ? "ORDER BY " + keyName : order;

            // 执行查询
            if (pageIndex == 1)
            {
                sql = string.Format("SELECT TOP {0} {1} FROM {2} WHERE 1=1{3} {4}", pageSize, field, table, condition, order);
                return GetDataTable(sql, args);
            }

            string innerSql = string.Format("SELECT ROW_NUMBER() OVER ({0}) AS TempRowNumber,{1} FROM {2} WHERE 1=1{3}", order, field, table, condition);

            int startRowNumber = (pageIndex - 1) * pageSize + 1;
            int endRowNumber = startRowNumber + pageSize - 1;
            sql = string.Format("SELECT * FROM ({0}) AS TempTable WHERE TempRowNumber BETWEEN {1} AND {2}", innerSql, startRowNumber, endRowNumber);

            /* 原始的排序方式
            sql = "SELECT TOP " + pageSize + " " + field + " FROM " + table + " WHERE " + key + " NOT IN";
            sql += "(SELECT TOP " + (pageIndex - 1) * pageSize + " " + key + " FROM " + table + " WHERE 1=1" + condition + orderNew + ")";
            sql += condition + orderNew;*/

            // 返回查询结果
            return GetDataTable(sql, args);
        }

        /// <summary>
        /// 多表查询 - 分页扩展
        /// </summary>
        /// <param name="keyName">主键字段</param>
        /// <param name="field">要查询的字段，如：* | Id,Field</param>
        /// <param name="table">表名</param>
        /// <param name="htCondition">条件字符串</param>
        /// <param name="order">排序，包括排序字段和排序方式(如：id desc)</param>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页显示行数</param>
        /// <param name="recordCount">总行数</param>
        /// <param name="pageCount">总共页码数</param>
        /// <returns></returns>
        public DataTable GetPageNavigateDataTable(string keyName, string field, string table, string condition,
            string group, string order, ArrayList args, int pageIndex, int pageSize, out int recordCount, out int pageCount)
        {
            // 获取记录数
            string sql = string.Format("SELECT COUNT(1) from(select {0} FROM {1} WHERE 1=1{2} group by {3}) tmp", field, table, condition, group);
            recordCount = (int)ExecuteScalar(sql, args);

            // 获取页数
            pageCount = recordCount % pageSize == 0 ? recordCount / pageSize : recordCount / pageSize + 1;

            // 显示当前页的范围，下面两行上下顺序不可颠倒，如果颠倒，记录为0时会出现 负值
            if (pageIndex > pageCount) pageIndex = pageCount;
            if (pageIndex < 1) pageIndex = 1;

            //判断分组是否为空
            group = string.IsNullOrWhiteSpace(group) ? " " : " Group by " + group;

            // 判断排序参数order是否为空
            order = string.IsNullOrWhiteSpace(order) ? "ORDER BY " + keyName : order;


            // 执行查询
            if (pageIndex == 1)
            {
                sql = string.Format("SELECT TOP {0} * from (select {1} FROM {2} WHERE 1=1{3} {4}) tmp {5}", pageSize, field, table, condition, group, order);
                return GetDataTable(sql, args);
            }

            string innerSql = string.Format("SELECT ROW_NUMBER() OVER ({0}) AS TempRowNumber,* from (select {1} FROM {2} WHERE 1=1{3} {4}) tmp", order, field, table, condition, group);

            int startRowNumber = (pageIndex - 1) * pageSize + 1;
            int endRowNumber = startRowNumber + pageSize - 1;
            sql = string.Format("SELECT * FROM ({0}) AS TempTable WHERE TempRowNumber BETWEEN {1} AND {2}", innerSql, startRowNumber, endRowNumber);

            /* 原始的排序方式
            sql = "SELECT TOP " + pageSize + " " + field + " FROM " + table + " WHERE " + key + " NOT IN";
            sql += "(SELECT TOP " + (pageIndex - 1) * pageSize + " " + key + " FROM " + table + " WHERE 1=1" + condition + orderNew + ")";
            sql += condition + orderNew;*/
            // 返回查询结果
            return GetDataTable(sql, args);
        }
        #endregion
    }
}
