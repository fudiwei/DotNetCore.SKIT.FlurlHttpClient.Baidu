using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [GET] /rest/2.0/smartapp/pay/paymentservice/dict 接口的响应。</para>
    /// </summary>
    public class RestPayPaymentServiceDictionaryResponse : BaiduSmartAppThirdPartyResponse<RestPayPaymentServiceDictionaryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Province
                    {
                        /// <summary>
                        /// 获取或设置省份 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("provinceId")]
                        [System.Text.Json.Serialization.JsonPropertyName("provinceId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ProvinceId { get; set; }

                        /// <summary>
                        /// 获取或设置省份名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("provinceName")]
                        [System.Text.Json.Serialization.JsonPropertyName("provinceName")]
                        public string ProvinceName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cities")]
                        [System.Text.Json.Serialization.JsonPropertyName("cities")]
                        public City[] CityList { get; set; } = default!;
                    }

                    public class City
                    {
                        /// <summary>
                        /// 获取或设置城市 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cityId")]
                        [System.Text.Json.Serialization.JsonPropertyName("cityId")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CityId { get; set; }

                        /// <summary>
                        /// 获取或设置城市名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cityName")]
                        [System.Text.Json.Serialization.JsonPropertyName("cityName")]
                        public string CityName { get; set; } = default!;
                    }

                    public class Bank
                    {
                        public static class Types
                        {
                            public class Bank
                            {
                                /// <summary>
                                /// 获取或设置银行 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("bankId")]
                                [System.Text.Json.Serialization.JsonPropertyName("bankId")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int BankId { get; set; }

                                /// <summary>
                                /// 获取或设置银行名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("bankName")]
                                [System.Text.Json.Serialization.JsonPropertyName("bankName")]
                                public string BankName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 Logo URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("logoUrl")]
                                [System.Text.Json.Serialization.JsonPropertyName("logoUrl")]
                                public string? LogoUrl { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置首字母。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("character")]
                        [System.Text.Json.Serialization.JsonPropertyName("character")]
                        public string InitialCharacter { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置银行列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("banks")]
                        [System.Text.Json.Serialization.JsonPropertyName("banks")]
                        public Types.Bank[] BankList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置省份列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_list")]
                [System.Text.Json.Serialization.JsonPropertyName("province_list")]
                public Types.Province[] ProvinceList { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_list")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_list")]
                public Types.Bank[] BankList { get; set; } = default!;

                /// <summary>
                /// 获取或设置佣金比例字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commissionRate")]
                [System.Text.Json.Serialization.JsonPropertyName("commissionRate")]
                public IDictionary<int, string> CommissionRateMap { get; set; } = default!;

                /// <summary>
                /// 获取或设置结算周期字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paymentDays")]
                [System.Text.Json.Serialization.JsonPropertyName("paymentDays")]
                public IDictionary<int, string> PaymentDaysMap { get; set; } = default!;
            }
        }
    }
}
