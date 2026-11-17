namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/app/setnicknamewithqual 接口的请求。</para>
    /// </summary>
    public class RestAppSetNickNameWithQualificationRequest : BaiduSmartAppThirdPartyRequest
    {
        public static class Types
        {
            public class QualificationMaterial
            {
                /// <summary>
                /// 获取或设置商标证书文件 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trademark")]
                [System.Text.Json.Serialization.JsonPropertyName("trademark")]
                public List<string>? TrademarkQualificationUrlList { get; set; }

                /// <summary>
                /// 获取或设置授权证书文件 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("authorization")]
                [System.Text.Json.Serialization.JsonPropertyName("authorization")]
                public List<string>? AuthorizationQualificationUrlList { get; set; }

                /// <summary>
                /// 获取或设置 ICP 备案截图文件 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("icpImg")]
                [System.Text.Json.Serialization.JsonPropertyName("icpImg")]
                public List<string>? ICPImageQualificationUrlList { get; set; }

                /// <summary>
                /// 获取或设置旗舰店授权书文件 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ultimate")]
                [System.Text.Json.Serialization.JsonPropertyName("ultimate")]
                public List<string>? UltimateQualificationUrlList { get; set; }

                /// <summary>
                /// 获取或设置专卖店授权书文件 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("professional")]
                [System.Text.Json.Serialization.JsonPropertyName("professional")]
                public List<string>? ProfessionalQualificationUrlList { get; set; }

                /// <summary>
                /// 获取或设置补充材料文件 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("others")]
                [System.Text.Json.Serialization.JsonPropertyName("others")]
                public List<string>? OtherQualificationUrlList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nick_name")]
        [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// 获取或设置资质证明材料信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qual_materials")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("qual_materials")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedObjectInJsonFormatConverter))]
        public Types.QualificationMaterial? QualificationMaterial { get; set; }
    }
}
