using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFac.Repository.IRepository;
using AutoFac.Service.IService;

namespace AutoFac.Service
{
    public class BaseService<T> : IBaseService<T>
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public T Get(object id)
        {
            return _baseRepository.Get(id);
        }

        public T GetModel(string id)
        {
            return this._baseRepository.GetModel(id);
        }

        public List<T> GetModelList()
        {
            return _baseRepository.GetModelList();
        }

    }
}
