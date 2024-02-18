namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/app/info 接口的响应。</para>
    /// </summary>
    public class RestAppInfoResponse : BaiduSmartAppThirdPartyResponse<RestAppInfoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Qualification
                    {
                        /// <summary>
                        /// 获取或设置主体名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主体类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置主体审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置真实性认证类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_type")]
                        public int AdType { get; set; }

                        /// <summary>
                        /// 获取或设置真实性认证状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_status")]
                        public int AdStatus { get; set; }
                    }

                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                        public int CategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                        public string CategoryName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置类目描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_desc")]
                        public string? CategoryDesc { get; set; }

                        /// <summary>
                        /// 获取或设置类目审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                        public int? AuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置审核失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? RejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置父级类目信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent")]
                        public Category? ParentCategory { get; set; }
                    }

                    public class AuditInfo
                    {
                        /// <summary>
                        /// 获取或设置小程序名称审核值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_app_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_app_name")]
                        public string AppName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序名称审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_app_name_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_app_name_status")]
                        public int AppNameAuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置小程序名称审核失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_app_name_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_app_name_reason")]
                        public string? AppNameRejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置小程序介绍审核值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_app_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_app_desc")]
                        public string AppDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序介绍审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_app_desc_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_app_desc_status")]
                        public int AppDescriptionAuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置小程序介绍审核失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_app_desc_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_app_desc_reason")]
                        public string? AppDescriptionRejectReason { get; set; }

                        /// <summary>
                        /// 获取或设置小程序头像审核值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_photo_addr")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_photo_addr")]
                        public string? HeadImage { get; set; }

                        /// <summary>
                        /// 获取或设置小程序头像审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_photo_addr_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_photo_addr_status")]
                        public int HeadImageAuditStatus { get; set; }

                        /// <summary>
                        /// 获取或设置小程序头像审核失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_photo_addr_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_photo_addr_reason")]
                        public string? HeadImageRejectReason { get; set; }
                    }

                    public class ModifyInfo
                    {
                        /// <summary>
                        /// 获取或设置小程序名称已修改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name_modify_used")]
                        [System.Text.Json.Serialization.JsonPropertyName("name_modify_used")]
                        public int AppNameModifyUsedCount { get; set; }

                        /// <summary>
                        /// 获取或设置小程序名称总共可修改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name_modify_quota")]
                        [System.Text.Json.Serialization.JsonPropertyName("name_modify_quota")]
                        public int AppNameModifyQuota { get; set; }

                        /// <summary>
                        /// 获取或设置小程序介绍已修改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("signature_modify_used")]
                        [System.Text.Json.Serialization.JsonPropertyName("signature_modify_used")]
                        public int AppDescriptionModifyUsedCount { get; set; }

                        /// <summary>
                        /// 获取或设置小程序介绍总共可修改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("signature_modify_quota")]
                        [System.Text.Json.Serialization.JsonPropertyName("signature_modify_quota")]
                        public int AppDescriptionModifyQuota { get; set; }

                        /// <summary>
                        /// 获取或设置小程序头像已修改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_modify_used")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_modify_used")]
                        public int HeadImageModifyUsedCount { get; set; }

                        /// <summary>
                        /// 获取或设置小程序头像总共可修改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_modify_quota")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_modify_quota")]
                        public int HeadImageModifyQuota { get; set; }

                        /// <summary>
                        /// 获取或设置类目已修改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_modify_used")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_modify_used")]
                        public int CategoryModifyUsedCount { get; set; }

                        /// <summary>
                        /// 获取或设置类目总共可修改次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_modify_quota")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_modify_quota")]
                        public int CategoryModifyQuota { get; set; }
                    }

                    public class AuthInfo
                    {
                        /// <summary>
                        /// 获取或设置权限类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置权限名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scope_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("scope_name")]
                        public string ScopeName { get; set; } = default!;
                    }

                    public class AnnualReviewInfo
                    {
                        /// <summary>
                        /// 获取或设置年审状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("annual_review_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("annual_review_status")]
                        public int AnnualReviewStatus { get; set; }

                        /// <summary>
                        /// 获取或设置年审过期时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("annual_review_overdue_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("annual_review_overdue_time")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long? AnnualReviewOverdueTimestamp { get; set; }
                    }

                    public class AppOfflineInfo
                    {
                        /// <summary>
                        /// 获取或设置强制下线类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("offline_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("offline_reason")]
                        public int OfflineReasonType { get; set; }

                        /// <summary>
                        /// 获取或设置强制下线原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("illegal_fields")]
                        [System.Text.Json.Serialization.JsonPropertyName("illegal_fields")]
                        public string? IllegalFields { get; set; }
                    }
                }

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
                /// 获取或设置小程序 AppKey。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_key")]
                [System.Text.Json.Serialization.JsonPropertyName("app_key")]
                public string AppKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序介绍。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("app_desc")]
                public string AppDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("photo_addr")]
                [System.Text.Json.Serialization.JsonPropertyName("photo_addr")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置主体信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification")]
                public Types.Qualification Qualification { get; set; } = default!;

                /// <summary>
                /// 获取或设置类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public Types.Category[] CategoryList { get; set; } = default!;

                /// <summary>
                /// 获取或设置基本信息审核信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_info")]
                public Types.AuditInfo? AuditInfo { get; set; }

                /// <summary>
                /// 获取或设置小程序基本信息修改次数信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_count")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_count")]
                public Types.ModifyInfo? ModifyInfo { get; set; }

                /// <summary>
                /// 获取或设置权限集合列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_info")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
                public Types.AuthInfo[]? AuthInfoList { get; set; }

                /// <summary>
                /// 获取或设置小程序年审相关信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("annual_review_info")]
                [System.Text.Json.Serialization.JsonPropertyName("annual_review_info")]
                public Types.AnnualReviewInfo? AnnualReviewInfo { get; set; }

                /// <summary>
                /// 获取或设置小程序强制下线相关信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_offline_info")]
                [System.Text.Json.Serialization.JsonPropertyName("app_offline_info")]
                public Types.AppOfflineInfo[]? AppOfflineInfoList { get; set; }

                /// <summary>
                /// 获取或设置小程序状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置小程序的 Web 化开关状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("web_status")]
                [System.Text.Json.Serialization.JsonPropertyName("web_status")]
                public int WebStatus { get; set; }

                /// <summary>
                /// 获取或设置开发者工具最低版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("min_swan_version")]
                [System.Text.Json.Serialization.JsonPropertyName("min_swan_version")]
                public string MinSwanVersion { get; set; } = default!;
            }
        }
    }
}
