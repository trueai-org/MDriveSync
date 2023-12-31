﻿using System.Text.Json.Serialization;

namespace MDriveSync.Core.Models
{
    /// <summary>
    /// 获取授权二维码
    /// https://www.yuque.com/aliyundrive/zpfszx/ttfoy0xt2pza8lof
    /// </summary>
    public class AliyunDriveOAuthAuthorizeQrCodeResponse
    {
        /// <summary>
        /// 二维码地址
        /// </summary>
        [JsonPropertyName("qrCodeUrl")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 登录随机数，用来获取用户登录状态
        /// </summary>
        [JsonPropertyName("sid")]
        public string Sid { get; set; }
    }
}