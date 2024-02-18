using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/v1.0/coupon/banner/get 接口的请求。</para>
    /// </summary>
    public class RestCouponBannerGetRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置卡券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CouponId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 Banner ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<long> BannerIdList { get; set; } = new List<long>();
    }
}
