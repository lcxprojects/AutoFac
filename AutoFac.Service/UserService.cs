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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public List<User> GetModelList(int isEnabled = 1)
        {
            return this._userRepository.GetModelList(isEnabled);
        }

    }
}
