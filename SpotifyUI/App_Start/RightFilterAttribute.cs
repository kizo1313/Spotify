using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 

namespace 项目UI.App_Start
{
    /// <summary>
    /// 过滤器类
    /// 特性
    /// </summary>
    public class RightFilterAttribute: ActionFilterAttribute
    {
        /// <summary>
        /// 过滤器： 执行动作方法的时候进行干预
        /// 动作方法执行前干预
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           //if (filterContext.HttpContext.Request.IsAjaxRequest()) return;

           // var info = filterContext.HttpContext.Session["user"] as Admin;
           // if (info == null)
           // {
           //     filterContext.Result = new RedirectResult("/Account/Login");
           //     return;
           // }
           // string areaName = filterContext.RouteData.DataTokens["area"] as string + "/";
           // string controllerName = filterContext.ActionDescriptor
           //     .ControllerDescriptor.ControllerName+"/";
           // string actionName = filterContext.ActionDescriptor
           //     .ActionName;
           // string url = $"/{areaName}{controllerName}{actionName}";

           // var list = info.tblRole.tblMenu
           //     .Where(x => x.MenuUrl == url)
           //     .ToList();
           // if(list.Count==0)
           // { 
           //     filterContext.Result =
           //     new ContentResult() { Content = "你没有权限，请绕道!!" };
           // }



        }
    }
}