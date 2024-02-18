namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/subchain/getall 接口的响应。</para>
    /// </summary>
    public class RestSubchainGetAllResponse : BaiduSmartAppThirdPartyResponse<RestSubchainGetAllResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Subchain
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                        public string AppName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主体 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long CusomterId { get; set; }

                        /// <summary>
                        /// 获取或设置主体名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_name")]
                        public string CusomterName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置子链 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long SubchainId { get; set; }

                        /// <summary>
                        /// 获取或设置子链类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subchain_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("subchain_type")]
                        public int SubchainType { get; set; }

                        /// <summary>
                        /// 获取或设置子链名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("chain_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("chain_name")]
                        public string SubchainName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置子链描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("chain_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("chain_desc")]
                        public string SubchainDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("chain_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("chain_path")]
                        public string? PagePath { get; set; }

                        /// <summary>
                        /// 获取或设置页面路径 MD5 校验值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path_md5")]
                        [System.Text.Json.Serialization.JsonPropertyName("path_md5")]
                        public string? PagePathMD5 { get; set; }

                        /// <summary>
                        /// 获取或设置客服电话号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("telephone")]
                        [System.Text.Json.Serialization.JsonPropertyName("telephone")]
                        public string? PhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置展示顺序。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("chain_rank")]
                        [System.Text.Json.Serialization.JsonPropertyName("chain_rank")]
                        public int Rank { get; set; }

                        /// <summary>
                        /// 获取或设置展示状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("show_status")]
                        public int? ShowStatus { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置审核时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_time")]
                        public long? AuditTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置审核描述信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_desc")]
                        public string? AuditDescription { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小程序等级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_level")]
                [System.Text.Json.Serialization.JsonPropertyName("app_level")]
                public int AppLevel { get; set; }

                /// <summary>
                /// 获取或设置展示的单卡子链个数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_chain_prior_number")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_chain_prior_number")]
                public int SubchainPriorityNumber { get; set; }

                /// <summary>
                /// 获取或设置子链列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_chain_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_chain_info_list")]
                public Types.Subchain[] SubchainList { get; set; } = default!;
            }
        }
    }
}
