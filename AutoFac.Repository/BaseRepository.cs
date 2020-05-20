using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFac.DBUtility;
using AutoFac.Repository.IRepository;

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
    }
}
