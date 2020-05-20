using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.Common.ShowResultMessage
{
    public class ResultMessage
    {
        /// <summary>
        /// 操作成功!
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <returns></returns>
        public static CallbackInfo Success(string msg = "操作成功!")
        {
            var callback = new CallbackInfo();
            callback.StatusCode = StatusCode.Ok;
            callback.Message = msg;

            return callback;
        }

        /// <summary>
        /// 操作失败!
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <returns></returns>
        public static CallbackInfo Faild(string msg = "操作失败!")
        {
            var callback = new CallbackInfo();
            callback.StatusCode = StatusCode.Error;
            callback.Message = msg;
            return callback;
        }

        /// <summary>
        /// 登录超时!
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <returns></returns>
        public static CallbackInfo TimeOut(string msg = "登录超时,请重新登录!")
        {
            var callback = new CallbackInfo();
            callback.StatusCode = StatusCode.TimeOut;
            callback.Message = msg;
            return callback;
        }
    }

    public static class ResultMessage<T>
    {

        /// <summary>
        /// 操作成功!
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <returns></returns>
        public static CallbackInfo<T> Success(string msg = "操作成功！")
        {
            var callback = new CallbackInfo<T>();
            callback.StatusCode = StatusCode.Ok;
            callback.Message = msg;

            return callback;
        }

        /// <summary>
        /// 操作失败!
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <returns></returns>
        public static CallbackInfo<T> Faild(string msg = "操作失败！")
        {
            var callback = new CallbackInfo<T>();
            callback.StatusCode = StatusCode.Error;
            callback.Message = msg;
            return callback;
        }

        /// <summary>
        /// 登录超时!
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <returns></returns>
        public static CallbackInfo<T> TimeOut(string msg = "登录超时,请重新登录！")
        {
            var callback = new CallbackInfo<T>();
            callback.StatusCode = StatusCode.TimeOut;
            callback.Message = msg;
            return callback;
        }

    }

}
