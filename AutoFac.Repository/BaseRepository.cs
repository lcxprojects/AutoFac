using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFac.DBUtility;
using AutoFac.Repository.IRepository;
using Dapper.Contrib.Extensions;

namespace AutoFac.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        public bool Delete(string id)
        {
            var sql = $"delete from [{typeof(T).Name}] where Id=@id";
            return DapperHelper.Delete(sql, id);
        }

        public T GetModel(string id)
        {
            var sql = $"select * from [{typeof(T).Name}] where Id=@id";

            return DapperHelper.GetModel<T>(sql, new { id = id });
        }

        public List<T> GetModelList()
        {
            var sql = $"select * from [{typeof(T).Name}] ";

            return DapperHelper.GetModelList<T>(sql, null);
        }

        //public bool Insert(T model)
        //{
        //    using (var conn = DapperHelper.GetSqlConnectionInstance())
        //    {
        //        try
        //        {
        //            return conn.Insert(model) > 0;
        //        }
        //        catch (Exception e)
        //        {
        //            return false;
        //        }
        //    }
        //}

        //public bool Update(T model)
        //{
        //    using (var conn = DapperHelper.GetSqlConnectionInstance())
        //    {
        //        try
        //        {
        //            return conn.Update(model);
        //        }
        //        catch (Exception e)
        //        {
        //            return false;
        //        }
        //    }
        //}


        //public bool Delete(T model)
        //{
        //    using (var conn = DapperHelper.GetSqlConnectionInstance())
        //    {
        //        try
        //        {
        //            return conn.Delete(model);
        //        }
        //        catch (Exception e)
        //        {
        //            return false;
        //        }
        //    }
        //}

        //public T Get(object id)
        //{
        //    using (var conn = DapperHelper.GetSqlConnectionInstance())
        //    {
        //        try
        //        {
        //            return conn.Get<T>(id);
        //        }
        //        catch (Exception e)
        //        {
        //            return null;
        //        }
        //    }
        //}


    }
}
