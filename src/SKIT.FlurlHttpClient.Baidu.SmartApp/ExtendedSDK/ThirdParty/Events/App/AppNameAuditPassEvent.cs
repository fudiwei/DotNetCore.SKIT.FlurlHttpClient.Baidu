namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty.Events
{
    /// <summary>
    /// <para>表示 APP_NAME_AUDIT_PASS 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://smartprogram.baidu.com/docs/third/info/info_push/ ]]>
    /// </para>
    /// </summary>
    public class AppNameAuditPassEvent : BaiduSmartAppThirdPartyEvent
    {
        /// <summary>
        /// 获取或设置小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AppName")]
        [System.Text.Json.Serialization.JsonPropertyName("AppName")]
        public string AppName { get; set; } = default!;
    }
}
