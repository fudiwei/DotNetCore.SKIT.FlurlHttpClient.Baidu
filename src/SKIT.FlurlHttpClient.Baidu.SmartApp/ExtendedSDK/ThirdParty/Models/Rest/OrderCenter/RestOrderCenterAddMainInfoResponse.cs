namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/ordercenter/add/main/info 接口的响应。</para>
    /// </summary>
    public class RestOrderCenterAddMainInfoResponse : BaiduSmartAppThirdPartyResponse<RestOrderCenterAddMainInfoResponse.Types.Result[]>
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置小程序 AppKey。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_app_id")]
                public string AppKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单种类。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cate_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cate_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int OrderCategory { get; set; }

                /// <summary>
                /// 获取或设置开发者自定义订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resource_id")]
                [System.Text.Json.Serialization.JsonPropertyName("resource_id")]
                public string OutOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置受影响行数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rows_affected")]
                [System.Text.Json.Serialization.JsonPropertyName("rows_affected")]
                public int AffectedRows { get; set; }
            }
        }
    }
}
