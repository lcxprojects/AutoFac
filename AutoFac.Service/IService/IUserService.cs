using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFac.Model;

namespace AutoFac.Service.IService
{
    public interface IUserService : IBaseService<User>
    {
        List<User> GetModelList(int isEnabled = 1);

    }
}
