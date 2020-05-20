using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.Common.ShowResultMessage
{
    public class CallbackInfo<T>
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// 返回提示语
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 返回前台的用户数据
        /// </summary>
        public T Data { get; set; }
    }

    /// <summary>
    /// 返回消息实体
    /// </summary>
    public class CallbackInfo : CallbackInfo<object>
    {

    }

    /// <summary>
    /// 返回状态码 
    /// </summary>
    public enum StatusCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        Ok = 200,
        /// <summary>
        /// 失败
        /// </summary>
        Error = 300,
        /// <summary>
        /// 登录超时
        /// </summary>
        TimeOut = 301
    }
}
