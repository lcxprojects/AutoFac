using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.Service.IService
{
    public interface IBaseService<T>
    {
        T GetModel(string id);

        List<T> GetModelList();

    }
}
