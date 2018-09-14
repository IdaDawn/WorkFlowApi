using Common;
using System;

namespace Core
{
    /// <summary>
    /// 统一返回类
    /// </summary>
    public class ResponseMessage
    {
        /// <summary>
        /// 状态标识
        /// </summary>
        public object state { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 状态码
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 返回的数据
        /// </summary>
        public object data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JsonHelper.SerializeObjectToString(this);
        }
    }
    /// <summary>
    /// 状态标识枚举
    /// </summary>
    public enum ResultType
    {
        /// <summary>
        /// 消息标识
        /// </summary>
        info,
        /// <summary>
        /// 成功标识
        /// </summary>
        success,
        /// <summary>
        /// 警告标识
        /// </summary>
        warning,
        /// <summary>
        /// 异常标识
        /// </summary>
        error
    }
}
