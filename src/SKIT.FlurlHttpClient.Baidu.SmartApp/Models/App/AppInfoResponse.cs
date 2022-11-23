using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.App
{
    public class AppInfoResponse : SmartAppResponse<AppInfoResponseData>
    {
    }

    public class AppInfoResponseData
    {
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public int AppId { get; set; }

        [Newtonsoft.Json.JsonProperty("app_name")]
        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
        public string AppName { get; set; }

        [Newtonsoft.Json.JsonProperty("app_key")]
        [System.Text.Json.Serialization.JsonPropertyName("app_key")]
        public string AppKey { get; set; }

        [Newtonsoft.Json.JsonProperty("app_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("app_desc")]
        public string AppDesc { get; set; }

        [Newtonsoft.Json.JsonProperty("photo_addr")]
        [System.Text.Json.Serialization.JsonPropertyName("photo_addr")]
        public string PhotoAddr { get; set; }

        [Newtonsoft.Json.JsonProperty("qualification")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification")]
        public Qualification Qualification { get; set; }

        [Newtonsoft.Json.JsonProperty("modify_count")]
        [System.Text.Json.Serialization.JsonPropertyName("modify_count")]
        public ModifyInfo ModifyCount { get; set; }

        [Newtonsoft.Json.JsonProperty("category")]
        [System.Text.Json.Serialization.JsonPropertyName("category")]
        public List<CategoryInfo> Category { get; set; }

        [Newtonsoft.Json.JsonProperty("audit_info")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_info")]
        public AuditInfo AuditInfo { get; set; }

        [Newtonsoft.Json.JsonProperty("auth_info")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
        public List<AuthInfo> AuthInfo { get; set; }

        [Newtonsoft.Json.JsonProperty("annual_review_info")]
        [System.Text.Json.Serialization.JsonPropertyName("annual_review_info")]
        public AnnualReviewInfo AnnualReviewInfo { get; set; }

        [Newtonsoft.Json.JsonProperty("app_offline_info")]
        [System.Text.Json.Serialization.JsonPropertyName("app_offline_info")]
        public List<AppOfflineInfo> AppOfflineInfo { get; set; }

        [Newtonsoft.Json.JsonProperty("min_swan_version")]
        [System.Text.Json.Serialization.JsonPropertyName("min_swan_version")]
        public string MinSwanVersion { get; set; }

        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        [Newtonsoft.Json.JsonProperty("web_status")]
        [System.Text.Json.Serialization.JsonPropertyName("web_status")]
        public int WebStatus { get; set; }
    }

    public class Qualification
    {
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        [Newtonsoft.Json.JsonProperty("ad_type")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_type")]
        public int AdType { get; set; }

        [Newtonsoft.Json.JsonProperty("ad_status")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_status")]
        public int AdStatus { get; set; }
    }

    public class ModifyInfo
    {
        [Newtonsoft.Json.JsonProperty("name_modify_used")]
        [System.Text.Json.Serialization.JsonPropertyName("name_modify_used")]
        public int NameModifyUsed { get; set; }

        [Newtonsoft.Json.JsonProperty("name_modify_quota")]
        [System.Text.Json.Serialization.JsonPropertyName("name_modify_quota")]
        public int NameModifyQuota { get; set; }

        [Newtonsoft.Json.JsonProperty("signature_modify_used")]
        [System.Text.Json.Serialization.JsonPropertyName("signature_modify_used")]
        public int SignatureModifyUsed { get; set; }

        [Newtonsoft.Json.JsonProperty("signature_modify_quota")]
        [System.Text.Json.Serialization.JsonPropertyName("signature_modify_quota")]
        public int SignatureModifyQuota { get; set; }

        [Newtonsoft.Json.JsonProperty("image_modify_used")]
        [System.Text.Json.Serialization.JsonPropertyName("image_modify_used")]
        public int ImageModifyUsed { get; set; }

        [Newtonsoft.Json.JsonProperty("image_modify_quota")]
        [System.Text.Json.Serialization.JsonPropertyName("image_modify_quota")]
        public int ImageModifyQuota { get; set; }

        [Newtonsoft.Json.JsonProperty("category_modify_used")]
        [System.Text.Json.Serialization.JsonPropertyName("category_modify_used")]
        public int CategoryModifyUsed { get; set; }

        [Newtonsoft.Json.JsonProperty("category_modify_quota")]
        [System.Text.Json.Serialization.JsonPropertyName("category_modify_quota")]
        public int CategoryModifyQuota { get; set; }
    }

    public class CategoryParentInfo
    {
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public int CategoryId { get; set; }

        [Newtonsoft.Json.JsonProperty("category_name")]
        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        [Newtonsoft.Json.JsonProperty("category_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("category_desc")]
        public string CategoryDesc { get; set; }
    }

    public class CategoryInfo
    {
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public int CategoryId { get; set; }

        [Newtonsoft.Json.JsonProperty("category_name")]
        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        [Newtonsoft.Json.JsonProperty("category_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("category_desc")]
        public string CategoryDesc { get; set; }

        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; set; }

        [Newtonsoft.Json.JsonProperty("audit_status")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
        public int AuditStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("parent")]
        [System.Text.Json.Serialization.JsonPropertyName("parent")]
        public CategoryParentInfo Parent { get; set; }
    }

    public class AuditInfo
    {
        [Newtonsoft.Json.JsonProperty("audit_app_name_status")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_app_name_status")]
        public int AuditAppNameStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("audit_app_name")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_app_name")]
        public string AuditAppName { get; set; }

        [Newtonsoft.Json.JsonProperty("audit_app_name_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_app_name_reason")]
        public string AuditAppNameReason { get; set; }

        [Newtonsoft.Json.JsonProperty("audit_app_desc_status")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_app_desc_status")]
        public int AuditAppDescStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("audit_app_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_app_desc")]
        public string AuditAppDesc { get; set; }

        [Newtonsoft.Json.JsonProperty("audit_app_desc_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_app_desc_reason")]
        public string AuditAppDescReason { get; set; }

        [Newtonsoft.Json.JsonProperty("audit_photo_addr_status")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_photo_addr_status")]
        public int AuditPhotoAddrStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("audit_photo_addr")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_photo_addr")]
        public string AuditPhotoAddr { get; set; }

        [Newtonsoft.Json.JsonProperty("audit_photo_addr_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_photo_addr_reason")]
        public string AuditPhotoAddrReason { get; set; }
    }

    public class AuthInfo
    {
        [Newtonsoft.Json.JsonProperty("scope_name")]
        [System.Text.Json.Serialization.JsonPropertyName("scope_name")]
        public string ScopeName { get; set; }

        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }
    }

    public class AnnualReviewInfo
    {
        [Newtonsoft.Json.JsonProperty("annual_review_status")]
        [System.Text.Json.Serialization.JsonPropertyName("annual_review_status")]
        public int AnnualReviewStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("annual_review_overdue_time")]
        [System.Text.Json.Serialization.JsonPropertyName("annual_review_overdue_time")]
        public int AnnualReviewOverdueTime { get; set; }
    }

    public class AppOfflineInfo
    {
        [Newtonsoft.Json.JsonProperty("offline_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("offline_reason")]
        public int OfflineReason { get; set; }

        [Newtonsoft.Json.JsonProperty("illegal_fields")]
        [System.Text.Json.Serialization.JsonPropertyName("illegal_fields")]
        public string IllegalFields { get; set; }
    }
}
