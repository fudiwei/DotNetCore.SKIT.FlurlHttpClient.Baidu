using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/v1.0/coupon/code/batchUpload 接口的请求。</para>
    /// </summary>
    public class RestCouponCodeBatchUploadRequest : BaiduSmartAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置卡券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponId")]
        [System.Text.Json.Serialization.JsonPropertyName("couponId")]
        public string CouponId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("couponCodes")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("couponCodes")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithCommaSplitConverter))]
        public IList<string> CouponCodeList { get; set; } = new List<string>();
    }
}
