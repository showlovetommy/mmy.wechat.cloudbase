using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mmy.Wechat.CloudBase
{
    public class CloudBaseMiddleware
    {
        private readonly RequestDelegate _next;
        public CloudBaseMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext, IWechatBaseHeader wechatBaseHeader)
        {
            var headers = httpContext.Request.Headers;
            wechatBaseHeader.OpenId = headers["x-wx-openid"].ToString();
            wechatBaseHeader.AppId = headers["x-wx-appid"].ToString();
            wechatBaseHeader.UnionId = headers["x-wx-unionid"].ToString();
            wechatBaseHeader.FromOpenId = headers["x-wx-from-openid"].ToString(); 
            wechatBaseHeader.FromAppId = headers["x-wx-from-appid"].ToString();
            wechatBaseHeader.FromUnionId = headers["x-wx-from-unionid"].ToString();
            wechatBaseHeader.Env = headers["x-wx-env"].ToString();
            wechatBaseHeader.Source = headers["x-wx-source"].ToString();
            wechatBaseHeader.ForwardedFor = headers["x-forwarded-for"].ToString();
            await _next(httpContext);
        }
    }
}
