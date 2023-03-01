using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.ThirdParty
{
    public static class BaiduSmartAppThirdPartyClientEventExtensions
    {
        private class InnerEncryptedEvent
        {
            [Newtonsoft.Json.JsonProperty("Encrypt")]
            [System.Text.Json.Serialization.JsonPropertyName("Encrypt")]
            public string EncryptedData { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("TimeStamp")]
            [System.Text.Json.Serialization.JsonPropertyName("TimeStamp")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
            public string TimestampString { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("Nonce")]
            [System.Text.Json.Serialization.JsonPropertyName("Nonce")]
            public string Nonce { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("MsgSignature")]
            [System.Text.Json.Serialization.JsonPropertyName("MsgSignature")]
            public string Signature { get; set; } = default!;
        }

        private static TEvent InnerDeserializeEventFromJson<TEvent>(BaiduSmartAppThirdPartyClient client, string callbackJson)
            where TEvent : BaiduSmartAppThirdPartyEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(callbackJson);

            try
            {
                if (callbackJson.Contains("\"Encrypt\""))
                {
                    if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                        throw new Exceptions.BaiduSmartAppEventSerializationException("Decrypt event failed, because there is no encoding AES key.");

                    InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(callbackJson);
                    callbackJson = Utilities.BaiduMsgCryptor.AESDecrypt(cipherText: encryptedEvent.EncryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
            }
            catch (BaiduSmartAppException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.BaiduSmartAppEventSerializationException("Deserialize event failed. Please see the `InnerException` for more details.", ex);
            }
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="BaiduSmartAppThirdPartyEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this BaiduSmartAppThirdPartyClient client, string callbackJson)
            where TEvent : BaiduSmartAppThirdPartyEvent, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="BaiduSmartAppThirdPartyEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static BaiduSmartAppThirdPartyEvent DeserializeEventFromJson(this BaiduSmartAppThirdPartyClient client, string callbackJson)
        {
            return InnerDeserializeEventFromJson<BaiduSmartAppThirdPartyEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>验证消息推送事件签名。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/customer/customerability/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">百度消息推送中的 "timestamp" 查询参数。</param>
        /// <param name="callbackNonce">百度消息推送中的 "nonce" 查询参数。</param>
        /// <param name="callbackSignature">百度消息推送中的 "signature" 查询参数。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureForEcho(this BaiduSmartAppThirdPartyClient client, string callbackTimestamp, string callbackNonce, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackTimestamp == null) throw new ArgumentNullException(nameof(callbackTimestamp));
            if (callbackNonce == null) throw new ArgumentNullException(nameof(callbackNonce));
            if (callbackSignature == null) throw new ArgumentNullException(nameof(callbackSignature));

            List<string> lstParams = new List<string>() { client.Credentials.PushToken!, callbackTimestamp, callbackNonce };
            lstParams.Sort(StringComparer.Ordinal);

            string sign = Utilities.SHA1Utility.Hash(string.Concat(lstParams));
            return string.Equals(sign, callbackSignature, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// <para>验证消息推送事件签名。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/third/push/encryption/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson">百度消息推送中请求正文（JSON 格式）。</param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this BaiduSmartAppThirdPartyClient client, string callbackJson)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(nameof(callbackJson));

            try
            {
                InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(callbackJson);
                return Utilities.BaiduMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: encryptedEvent.TimestampString,
                    sNonce: encryptedEvent.Nonce,
                    sMsgEncrypt: encryptedEvent.EncryptedData,
                    sMsgSign: encryptedEvent.Signature
                );
            }
            catch
            {
                return false;
            }
        }
    }
}
