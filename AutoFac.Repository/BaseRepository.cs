using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFac.DBUtility;
using AutoFac.Repository.IRepository;
using DapperExtensions;

namespace AutoFac.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
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

        public bool Insert(T model)
        {
            return DapperHelper.Insert(model);
        }

        public T Get(object id)
        {
            return DapperHelper.Get<T>(id);
        }

        public List<T> GetList(List<IPredicate> para, List<ISort> sort)
        {
            return DapperHelper.GetList<T>(para, sort);
        }


    }
}
