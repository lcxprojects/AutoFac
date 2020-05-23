using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.Repository.IRepository
{
    public interface IBaseRepository<T>
    {
        T GetModel(string id);

        List<T> GetModelList();

        bool Delete(string id);

        bool Insert(T model);
        //bool Update(T model);
        //bool Delete(T model);
        T Get(object id);


    }
}
