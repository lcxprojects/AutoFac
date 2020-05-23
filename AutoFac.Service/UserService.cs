using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFac.Model;
using AutoFac.Repository;
using AutoFac.Repository.IRepository;
using AutoFac.Service.IService;

namespace AutoFac.Service
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository, IBaseRepository<User> baseRepository) : base(baseRepository)
        {
            this._userRepository = userRepository;
        }

        public List<User> GetModelList(int isEnabled = 1)
        {
            return this._userRepository.GetModelList(isEnabled);
        }

    }
}
