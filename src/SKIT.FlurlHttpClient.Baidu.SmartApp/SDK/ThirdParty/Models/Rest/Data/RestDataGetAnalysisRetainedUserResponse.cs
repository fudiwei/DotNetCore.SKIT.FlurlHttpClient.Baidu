using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty.Models
{
    /// <summary>
    /// <para>表示 [POST] /rest/2.0/smartapp/data/getanalysisretaineduser 接口的响应。</para>
    /// </summary>
    public class RestDataGetAnalysisRetainedUserResponse : BaiduSmartAppThirdPartyResponse<RestDataGetAnalysisRetainedUserResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Summary
                    {
                        /// <summary>
                        /// 获取或设置活跃用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("active_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("active_user_count")]
                        public int ActiveUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置留存用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("retained_user_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("retained_user_count")]
                        public int? RetainedUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置留存率（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("retained_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("retained_ratio")]
                        public double? RetainedRatio { get; set; }
                    }

                    public class Statistic : Summary, IDictionary<string, object?>
                    {
                        private readonly IDictionary<string, object?> _dict = new Dictionary<string, object?>();

                        public object? this[string key]
                        {
                            get { return _dict[key]; }
                            set { _dict[key] = value; }
                        }

                        /// <summary>
                        /// 获取或设置指标名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        ICollection<string> IDictionary<string, object?>.Keys
                        {
                            get { return _dict.Keys; }
                        }

                        ICollection<object?> IDictionary<string, object?>.Values
                        {
                            get { return _dict.Values; }
                        }

                        int ICollection<KeyValuePair<string, object?>>.Count
                        {
                            get { return _dict.Count; }
                        }

                        bool ICollection<KeyValuePair<string, object?>>.IsReadOnly
                        {
                            get { return _dict.IsReadOnly; }
                        }

                        void IDictionary<string, object?>.Add(string key, object? value)
                        {
                            _dict.Add(key, value);
                        }

                        bool IDictionary<string, object?>.ContainsKey(string key)
                        {
                            return _dict.ContainsKey(key);
                        }

                        bool IDictionary<string, object?>.Remove(string key)
                        {
                            return _dict.Remove(key);
                        }

                        bool IDictionary<string, object?>.TryGetValue(string key, out object? value)
                        {
                            return _dict.TryGetValue(key, out value);
                        }

                        void ICollection<KeyValuePair<string, object?>>.Add(KeyValuePair<string, object?> item)
                        {
                            _dict.Add(item);
                        }

                        void ICollection<KeyValuePair<string, object?>>.Clear()
                        {
                            _dict.Clear();
                        }

                        bool ICollection<KeyValuePair<string, object?>>.Contains(KeyValuePair<string, object?> item)
                        {
                            return _dict.Contains(item);
                        }

                        void ICollection<KeyValuePair<string, object?>>.CopyTo(KeyValuePair<string, object?>[] array, int arrayIndex)
                        {
                            _dict.CopyTo(array, arrayIndex);
                        }

                        bool ICollection<KeyValuePair<string, object?>>.Remove(KeyValuePair<string, object?> item)
                        {
                            return _dict.Remove(item);
                        }

                        IEnumerator<KeyValuePair<string, object?>> IEnumerable<KeyValuePair<string, object?>>.GetEnumerator()
                        {
                            return _dict.GetEnumerator();
                        }

                        IEnumerator IEnumerable.GetEnumerator()
                        {
                            return ((IEnumerable)_dict).GetEnumerator();
                        }

                    }
                }

                /// <summary>
                /// 获取或设置时间范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_span")]
                [System.Text.Json.Serialization.JsonPropertyName("time_span")]
                public string TimeRange { get; set; } = default!;

                /// <summary>
                /// 获取或设置数据综合指标信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sum")]
                [System.Text.Json.Serialization.JsonPropertyName("sum")]
                public Types.Summary Summary { get; set; } = default!;

                /// <summary>
                /// 获取或设置数据指标列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("data_list")]
                public Types.Statistic[] StatisticList { get; set; } = default!;

                /// <summary>
                /// 获取或设置当前偏移位置。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("offset")]
                [System.Text.Json.Serialization.JsonPropertyName("offset")]
                public int PageOffset { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
