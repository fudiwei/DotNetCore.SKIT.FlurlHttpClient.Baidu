namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/pay/account/create 接口的请求。</para>
    /// </summary>
    public class RestPayAccountCreateRequest : BaiduSmartAppThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置经营范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("business_scope")]
        public string BusinessScope { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置经营范围所在省份。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_province")]
        [System.Text.Json.Serialization.JsonPropertyName("business_province")]
        public string BusinessProvince { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置经营范围所在城市。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_city")]
        [System.Text.Json.Serialization.JsonPropertyName("business_city")]
        public string BusinessCity { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置经营范围详细地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_detail_address")]
        [System.Text.Json.Serialization.JsonPropertyName("business_detail_address")]
        public string BusinessAddress { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置法人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_person")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
        public string LegalPersonName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置法人身份证号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_id")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_id")]
        public string LegalPersonIdNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置法人身份证正面照片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card_front_url")]
        [System.Text.Json.Serialization.JsonPropertyName("id_card_front_url")]
        public string LegalPersonIdCardFrontPictureUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置法人身份证背面照片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card_back_url")]
        [System.Text.Json.Serialization.JsonPropertyName("id_card_back_url")]
        public string LegalPersonIdCardBackPictureUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置法人身份证开始时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_card_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_card_start_time")]
        public string LegalPersonIdCardStartTimeString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置法人身份证结束时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_card_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_card_end_time")]
        public string LegalPersonIdCardEndTimeString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营业执照开始时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("license_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("license_start_time")]
        public string LicenseStartTimeString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营业执照结束时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("license_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("license_end_time")]
        public string LicenseEndTimeString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置行业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_id")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_id")]
        public int IndustryId { get; set; }

        /// <summary>
        /// 获取或设置行业资质 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manage_permit_url")]
        [System.Text.Json.Serialization.JsonPropertyName("manage_permit_url")]
        public string PermitQualificationUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置注册资本（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_capital")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_capital")]
        public long RegisteredCapital { get; set; }

        /// <summary>
        /// 获取或设置经营控股人是否与法人一致。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manager_same")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("manager_same")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsManagerSameWithLegalPerson { get; set; }

        /// <summary>
        /// 获取或设置经营控股人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manager")]
        [System.Text.Json.Serialization.JsonPropertyName("manager")]
        public string? ManagerName { get; set; }

        /// <summary>
        /// 获取或设置经营控股人证件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manager_card_type")]
        [System.Text.Json.Serialization.JsonPropertyName("manager_card_type")]
        public int? ManagerIdType { get; set; }

        /// <summary>
        /// 获取或设置经营控股人证件号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manager_card")]
        [System.Text.Json.Serialization.JsonPropertyName("manager_card")]
        public string? ManagerIdNumber { get; set; }

        /// <summary>
        /// 获取或设置经营控股人证件正面照片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manager_card_front_url")]
        [System.Text.Json.Serialization.JsonPropertyName("manager_card_front_url")]
        public string? ManagerIdCardFrontPictureUrl { get; set; }

        /// <summary>
        /// 获取或设置经营控股人证件背面照片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manager_card_back_url")]
        [System.Text.Json.Serialization.JsonPropertyName("manager_card_back_url")]
        public string? ManagerIdCardBackPictureUrl { get; set; }

        /// <summary>
        /// 获取或设置经营控股人证件开始时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manager_card_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("manager_card_start_time")]
        public string? ManagerIdCardStartTimeString { get; set; }

        /// <summary>
        /// 获取或设置经营控股人证件结束时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manager_card_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("manager_card_end_time")]
        public string? ManagerIdCardEndTimeString { get; set; }

        /// <summary>
        /// 获取或设置受益人是否与法人一致。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefit_same")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("benefit_same")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsBeneficiarySameWithLegalPerson { get; set; }

        /// <summary>
        /// 获取或设置受益人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefit")]
        [System.Text.Json.Serialization.JsonPropertyName("benefit")]
        public string? BeneficiaryName { get; set; }

        /// <summary>
        /// 获取或设置受益人证件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefit_card_type")]
        [System.Text.Json.Serialization.JsonPropertyName("benefit_card_type")]
        public int? BeneficiaryIdType { get; set; }

        /// <summary>
        /// 获取或设置受益人证件号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefit_card")]
        [System.Text.Json.Serialization.JsonPropertyName("benefit_card")]
        public string? BeneficiaryIdNumber { get; set; }

        /// <summary>
        /// 获取或设置受益人证件正面照片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefit_card_front_url")]
        [System.Text.Json.Serialization.JsonPropertyName("benefit_card_front_url")]
        public string? BeneficiaryIdCardFrontPictureUrl { get; set; }

        /// <summary>
        /// 获取或设置受益人证件背面照片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefit_card_back_url")]
        [System.Text.Json.Serialization.JsonPropertyName("benefit_card_back_url")]
        public string? BeneficiaryIdCardBackPictureUrl { get; set; }

        /// <summary>
        /// 获取或设置受益人证件开始时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefit_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("benefit_start_time")]
        public string? BeneficiaryIdCardStartTimeString { get; set; }

        /// <summary>
        /// 获取或设置受益人证件结束时间字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("benefit_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("benefit_end_time")]
        public string? BeneficiaryIdCardEndTimeString { get; set; }
    }
}
