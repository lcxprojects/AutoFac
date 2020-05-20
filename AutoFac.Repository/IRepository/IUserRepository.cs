using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFac.Model;

namespace AutoFac.Repository.IRepository
{
    public interface IUserRepository
    {
        List<User> GetModelList(int isEnabled = 1);

    }
}
