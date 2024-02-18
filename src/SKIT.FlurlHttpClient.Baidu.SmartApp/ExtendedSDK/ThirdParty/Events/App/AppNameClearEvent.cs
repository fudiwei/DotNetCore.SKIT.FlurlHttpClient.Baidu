namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 APP_NAME_CLEAR 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://smartprogram.baidu.com/docs/third/info/name_clear_push/ ]]>
    /// </para>
    /// </summary>
    public class AppNameClearEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置释放前的小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beforeAppName")]
        [System.Text.Json.Serialization.JsonPropertyName("beforeAppName")]
        public string BeforeAppName { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序当前名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appName")]
        [System.Text.Json.Serialization.JsonPropertyName("appName")]
        public string AppName { get; set; } = default!;

        /// <summary>
        /// 获取或设置名称释放原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; set; } = default!;
    }
}
