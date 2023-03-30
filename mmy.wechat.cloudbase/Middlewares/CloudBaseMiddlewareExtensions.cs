using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mmy.Wechat.CloudBase
{
    public static class CloudBaseMiddlewareExtensions
    {
        public static IServiceCollection AddCloudBaseHeader(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IWechatBaseHeader, DefaultWechatBaseHeader>();
            return serviceCollection;
        }
        public static IApplicationBuilder UseCloudBaseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CloudBaseMiddleware>();
        }
    }
}
