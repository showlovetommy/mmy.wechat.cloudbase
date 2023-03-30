using System;

namespace Mmy.Wechat.CloudBase
{
    /// <summary>
    /// 请求头字段集合
    /// </summary>
    public interface IWechatBaseHeader
    {
        /// <summary>
        /// 小程序用户 openid
        /// </summary>
        string? OpenId { get; set; }
        /// <summary>
        /// 小程序 AppID
        /// </summary>
        string? AppId { get; set; }
        /// <summary>
        /// 小程序用户 unionid，并且满足 unionid 获取条件时有
        /// </summary>
        string? UnionId { get; set; }
        /// <summary>
        /// 资源复用情况下，小程序用户 openid
        /// </summary>
        string? FromOpenId { get; set; }
        /// <summary>
        /// 资源复用情况下，使用方小程序 AppID
        /// </summary>
        string? FromAppId { get; set; }
        /// <summary>
        /// 资源复用情况下，小程序用户 unionid，并且满足 unionid 获取条件时有
        /// </summary>
        string? FromUnionId { get; set; }
        /// <summary>
        /// 所在云环境 ID
        /// </summary>
        string? Env { get; set; }
        /// <summary>
        /// 调用来源（本次运行是被什么触发）
        /// </summary>
        string? Source { get; set; }
        /// <summary>
        /// 客户端 IPv4 或IPv6 地址
        /// </summary>
        string? ForwardedFor { get; set; }
    }
}
