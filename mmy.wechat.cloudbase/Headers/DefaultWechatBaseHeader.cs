using System;
using System.Collections.Generic;
using System.Text;

namespace Mmy.Wechat.CloudBase
{
    public class DefaultWechatBaseHeader : IWechatBaseHeader
    {
        public string? OpenId { get; set; }
        public string? AppId { get; set; }
        public string? UnionId { get; set; }
        public string? FromOpenId { get; set; }
        public string? FromAppId { get; set; }
        public string? FromUnionId { get; set; }
        public string? Env { get; set; }
        public string? Source { get; set; }
        public string? ForwardedFor { get; set; }
    }
}
