using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.SDK.OpenApi
{
    public static class BaiduSmartAppOpenApiClientEventExtensions
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

        private static TEvent InnerDeserializeEventFromJson<TEvent>(BaiduSmartAppOpenApiClient client, string callbackJson)
            where TEvent : BaiduSmartAppOpenApiEvent
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

        private static TEvent InnerDeserializeEventFromXml<TEvent>(BaiduSmartAppOpenApiClient client, string callbackXml)
            where TEvent : BaiduSmartAppOpenApiEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackXml == null) throw new ArgumentNullException(callbackXml);

            try
            {
                if (callbackXml.Contains("<Encrypt>") && callbackXml.Contains("</Encrypt>"))
                {
                    XDocument xDoc = XDocument.Parse(callbackXml);
                    string? msgEncrypt = xDoc.Root?.Element("Encrypt")?.Value;

                    if (string.IsNullOrEmpty(msgEncrypt))
                        throw new Exceptions.BaiduSmartAppEventSerializationException("Decrypt event failed, because of empty encrypted data.");

                    callbackXml = Utilities.BaiduMsgCryptor.AESDecrypt(cipherText: msgEncrypt!, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return Utilities.XmlUtility.Deserialize<TEvent>(callbackXml);
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
        /// <para>从 JSON 反序列化得到 <see cref="BaiduSmartAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this BaiduSmartAppOpenApiClient client, string callbackJson)
            where TEvent : BaiduSmartAppOpenApiEvent, BaiduSmartAppOpenApiEvent.Serialization.IJsonSerializable, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="BaiduSmartAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static BaiduSmartAppOpenApiEvent DeserializeEventFromJson(this BaiduSmartAppOpenApiClient client, string callbackJson)
        {
            return InnerDeserializeEventFromJson<BaiduSmartAppOpenApiEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="BaiduSmartAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this BaiduSmartAppOpenApiClient client, string callbackXml)
            where TEvent : BaiduSmartAppOpenApiEvent, BaiduSmartAppOpenApiEvent.Serialization.IXmlSerializable, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, callbackXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="BaiduSmartAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static BaiduSmartAppOpenApiEvent DeserializeEventFromXml(this BaiduSmartAppOpenApiClient client, string callbackXml)
        {
            return InnerDeserializeEventFromXml<BaiduSmartAppOpenApiEvent>(client, callbackXml);
        }

        /// <summary>
        /// <para>验证消息推送事件签名。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/developer_event_push/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">百度消息推送中的 "timestamp" 查询参数。</param>
        /// <param name="callbackNonce">百度消息推送中的 "nonce" 查询参数。</param>
        /// <param name="callbackSignature">百度消息推送中的 "signature" 查询参数。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureForEcho(this BaiduSmartAppOpenApiClient client, string callbackTimestamp, string callbackNonce, string callbackSignature)
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
        /// <para>验证消息推送事件签名（仅安全模式）。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/developer_event_push/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">百度消息推送中的 "timestamp" 查询参数。</param>
        /// <param name="callbackNonce">百度消息推送中的 "nonce" 查询参数。</param>
        /// <param name="callbackJson">百度消息推送中请求正文（JSON 格式）。</param>
        /// <param name="callbackSignature">百度消息推送中的 "msg_signature" 查询参数。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureFromJson(this BaiduSmartAppOpenApiClient client, string callbackTimestamp, string callbackNonce, string callbackJson, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(nameof(callbackJson));

            try
            {
                InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(callbackJson);
                return Utilities.BaiduMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: callbackTimestamp,
                    sNonce: callbackNonce,
                    sMsgEncrypt: encryptedEvent.EncryptedData,
                    sMsgSign: callbackSignature
                );
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// <para>验证消息推送事件签名（仅安全模式）。</para>
        /// <para>REF: https://smartprogram.baidu.com/docs/develop/serverapi/developer_event_push/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">百度消息推送中的 "timestamp" 查询参数。</param>
        /// <param name="callbackNonce">百度消息推送中的 "nonce" 查询参数。</param>
        /// <param name="callbackXml">百度消息推送中请求正文（XML 格式）。</param>
        /// <param name="callbackSignature">百度消息推送中的 "msg_signature" 查询参数。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureFromXml(this BaiduSmartAppOpenApiClient client, string callbackTimestamp, string callbackNonce, string callbackXml, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackXml == null) throw new ArgumentNullException(nameof(callbackXml));

            try
            {
                XDocument xDoc = XDocument.Parse(callbackXml);
                string? msgEncrypt = xDoc.Root?.Element("Encrypt")?.Value;

                return Utilities.BaiduMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: callbackTimestamp,
                    sNonce: callbackNonce,
                    sMsgEncrypt: msgEncrypt!,
                    sMsgSign: callbackSignature
                );
            }
            catch
            {
                return false;
            }
        }
    }
}
