using System.Collections;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Models
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
                        public decimal? RetainedRatio { get; set; }
                    }

                    public class Statistic : Summary, IDictionary<string, object?>
                    {
                        private readonly IDictionary<string, object?> _innerDict = new Dictionary<string, object?>();

                        public object? this[string key]
                        {
                            get { return _innerDict[key]; }
                            set { _innerDict[key] = value; }
                        }

                        /// <summary>
                        /// 获取或设置指标名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        ICollection<string> IDictionary<string, object?>.Keys
                        {
                            get { return _innerDict.Keys; }
                        }

                        ICollection<object?> IDictionary<string, object?>.Values
                        {
                            get { return _innerDict.Values; }
                        }

                        int ICollection<KeyValuePair<string, object?>>.Count
                        {
                            get { return _innerDict.Count; }
                        }

                        bool ICollection<KeyValuePair<string, object?>>.IsReadOnly
                        {
                            get { return _innerDict.IsReadOnly; }
                        }

                        void IDictionary<string, object?>.Add(string key, object? value)
                        {
                            _innerDict.Add(key, value);
                        }

                        bool IDictionary<string, object?>.ContainsKey(string key)
                        {
                            return _innerDict.ContainsKey(key);
                        }

                        bool IDictionary<string, object?>.Remove(string key)
                        {
                            return _innerDict.Remove(key);
                        }

                        bool IDictionary<string, object?>.TryGetValue(string key, out object? value)
                        {
                            return _innerDict.TryGetValue(key, out value);
                        }

                        void ICollection<KeyValuePair<string, object?>>.Add(KeyValuePair<string, object?> item)
                        {
                            _innerDict.Add(item);
                        }

                        void ICollection<KeyValuePair<string, object?>>.Clear()
                        {
                            _innerDict.Clear();
                        }

                        bool ICollection<KeyValuePair<string, object?>>.Contains(KeyValuePair<string, object?> item)
                        {
                            return _innerDict.Contains(item);
                        }

                        void ICollection<KeyValuePair<string, object?>>.CopyTo(KeyValuePair<string, object?>[] array, int arrayIndex)
                        {
                            _innerDict.CopyTo(array, arrayIndex);
                        }

                        bool ICollection<KeyValuePair<string, object?>>.Remove(KeyValuePair<string, object?> item)
                        {
                            return _innerDict.Remove(item);
                        }

                        IEnumerator<KeyValuePair<string, object?>> IEnumerable<KeyValuePair<string, object?>>.GetEnumerator()
                        {
                            return _innerDict.GetEnumerator();
                        }

                        IEnumerator IEnumerable.GetEnumerator()
                        {
                            return ((IEnumerable)_innerDict).GetEnumerator();
                        }

                    }
                }

                /// <summary>
                /// 获取或设置时间范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_span")]
                [System.Text.Json.Serialization.JsonPropertyName("time_span")]
                public string? TimeRange { get; set; }

                /// <summary>
                /// 获取或设置数据综合指标信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sum")]
                [System.Text.Json.Serialization.JsonPropertyName("sum")]
                public Types.Summary? Summary { get; set; }

                /// <summary>
                /// 获取或设置数据指标列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("data_list")]
                public List<Types.Statistic>? StatisticList { get; set; }

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
