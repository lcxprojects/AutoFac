using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExtensions.Mapper;

namespace AutoFac.DBUtility
{
    public class BaseMapping<T> : ClassMapper<T> where T : class
    {
        public BaseMapping()
        {
            // 自定义映射的表名
            Table(typeof(T).Name);

            // 启用自动映射，一定要调用此方法
            AutoMap();
        }
    }
}
