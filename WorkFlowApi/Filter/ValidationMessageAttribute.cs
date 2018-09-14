using Application;
using Core;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WFlowApp;
using WFlowModel;

namespace WorkFlowApi.Filter
{
    /// <summary>
    /// 请求参数验证，统一处理筛选器
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class ValidationMessageAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 统一过滤
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            ValidationTokenApp tokenApp = new ValidationTokenApp();
            if (!actionContext.ModelState.IsValid || actionContext.ModelState["token"] == null || string.IsNullOrEmpty(actionContext.ModelState["token"].AttemptedValue) || !tokenApp.hasValidation(actionContext.ModelState["token"].AttemptedValue))
            {
                ResponseMessage resp = new ResponseMessage
                {
                    state = ResultType.error,
                    code = "10000",
                    message = "您没权限访问！"
                };
                //actionContext.Response = actionContext.Request.CreateResponse<ResponseMessage>(resp);
            }

            base.OnActionExecuting(actionContext);
        }
    }
}
