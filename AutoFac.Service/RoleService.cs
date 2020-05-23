using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFac.Model;
using AutoFac.Repository.IRepository;
using AutoFac.Service.IService;

namespace AutoFac.Service
{
    public partial class RoleService : BaseService<RoleModel>, IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository, IBaseRepository<RoleModel> baseRepository) : base(baseRepository)
        {
            _roleRepository = roleRepository;
        }




    }
}
