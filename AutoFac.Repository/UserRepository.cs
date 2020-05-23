using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFac.DBUtility;
using AutoFac.Model;
using AutoFac.Repository.IRepository;
using Dapper;

namespace AutoFac.Repository
{
    public partial class UserRepository : IUserRepository
    {
        public List<User> GetModelList(int isEnabled = 1)
        {
            var sql = $"select * from [User] where IsEnabled=@IsEnabled ";
            return DapperHelper.GetModelList<User>(sql, new { IsEnabled = isEnabled });
        }
    }
}
