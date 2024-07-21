using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.OpenApi
{
    using SKIT.FlurlHttpClient;
    using SKIT.FlurlHttpClient.Internal;
    using SKIT.FlurlHttpClient.Primitives;

    public static partial class BaiduSmartAppOpenApiClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="BaiduSmartAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this BaiduSmartAppOpenApiClient client, string webhookJson)
            where TEvent : BaiduSmartAppOpenApiEvent, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="BaiduSmartAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static BaiduSmartAppOpenApiEvent DeserializeEventFromJson(this BaiduSmartAppOpenApiClient client, string webhookJson)
        {
            return InnerDeserializeEventFromJson<BaiduSmartAppOpenApiEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="BaiduSmartAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this BaiduSmartAppOpenApiClient client, string webhookXml)
            where TEvent : BaiduSmartAppOpenApiEvent, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, webhookXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="BaiduSmartAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static BaiduSmartAppOpenApiEvent DeserializeEventFromXml(this BaiduSmartAppOpenApiClient client, string webhookXml)
        {
            return InnerDeserializeEventFromXml<BaiduSmartAppOpenApiEvent>(client, webhookXml);
        }

        /// <summary>
        /// <para>验证消息推送事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://smartprogram.baidu.com/docs/develop/serverapi/developer_event_push/ ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">百度消息推送中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">百度消息推送中的 "nonce" 查询参数。</param>
        /// <param name="webhookSignature">百度消息推送中的 "signature" 查询参数。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureForEcho(this BaiduSmartAppOpenApiClient client, string webhookTimestamp, string webhookNonce, string webhookSignature)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                List<string> temp = new List<string>() { client.Credentials.PushToken!, webhookTimestamp, webhookNonce };
                temp.Sort(StringComparer.Ordinal);

                string sign = Utilities.SHA1Utility.Hash(string.Concat(temp)).Value!;
                bool valid = string.Equals(sign, webhookSignature, StringComparison.OrdinalIgnoreCase);

                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{webhookSignature}\" is an illegal signature."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }

        /// <summary>
        /// <para>验证消息推送事件签名（仅安全模式）。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://smartprogram.baidu.com/docs/develop/serverapi/developer_event_push/ ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">百度消息推送中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">百度消息推送中的 "nonce" 查询参数。</param>
        /// <param name="webhookJson">百度消息推送中请求正文（JSON 格式）。</param>
        /// <param name="webhookSignature">百度消息推送中的 "msg_signature" 查询参数。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureFromJson(this BaiduSmartAppOpenApiClient client, string webhookTimestamp, string webhookNonce, string webhookJson, string webhookSignature)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(webhookJson);
                bool valid = Utilities.BaiduMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: webhookTimestamp,
                    sNonce: webhookNonce,
                    sMsgEncrypt: encryptedEvent.EncryptedData,
                    sMsgSign: webhookSignature
                );

                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{webhookSignature}\" is an illegal signature."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }

        /// <summary>
        /// <para>验证消息推送事件签名（仅安全模式）。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://smartprogram.baidu.com/docs/develop/serverapi/developer_event_push/ ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">百度消息推送中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">百度消息推送中的 "nonce" 查询参数。</param>
        /// <param name="webhookXml">百度消息推送中请求正文（XML 格式）。</param>
        /// <param name="webhookSignature">百度消息推送中的 "msg_signature" 查询参数。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureFromXml(this BaiduSmartAppOpenApiClient client, string webhookTimestamp, string webhookNonce, string webhookXml, string webhookSignature)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                XDocument xDoc = XDocument.Parse(webhookXml);
                string? msgEncrypt = xDoc.Root?.Element("Encrypt")?.Value;

                bool valid = Utilities.BaiduMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: webhookTimestamp,
                    sNonce: webhookNonce,
                    sMsgEncrypt: msgEncrypt!,
                    sMsgSign: webhookSignature
                );

                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{webhookSignature}\" is an illegal signature."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }
    }

    partial class BaiduSmartAppOpenApiClientEventExtensions
    {
        private class InnerEncryptedEvent
        {
            [Newtonsoft.Json.JsonProperty("Encrypt")]
            [System.Text.Json.Serialization.JsonPropertyName("Encrypt")]
            public string EncryptedData { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("TimeStamp")]
            [System.Text.Json.Serialization.JsonPropertyName("TimeStamp")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
            public string TimestampString { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("Nonce")]
            [System.Text.Json.Serialization.JsonPropertyName("Nonce")]
            public string Nonce { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("MsgSignature")]
            [System.Text.Json.Serialization.JsonPropertyName("MsgSignature")]
            public string Signature { get; set; } = default!;
        }

        private static TEvent InnerDeserializeEventFromJson<TEvent>(BaiduSmartAppOpenApiClient client, string webhookJson)
            where TEvent : BaiduSmartAppOpenApiEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            try
            {
                if (webhookJson.Contains("\"Encrypt\""))
                {
                    if (string.IsNullOrEmpty(client.Credentials.PushEncodingAESKey))
                        throw new BaiduSmartAppException("Failed to decrypt event data, because the push encoding AES key is empty.");

                    InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(webhookJson);
                    webhookJson = Utilities.BaiduMsgCryptor.AESDecrypt(cipherText: encryptedEvent.EncryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return client.JsonSerializer.Deserialize<TEvent>(webhookJson);
            }
            catch (BaiduSmartAppException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new BaiduSmartAppException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }

        private static TEvent InnerDeserializeEventFromXml<TEvent>(BaiduSmartAppOpenApiClient client, string webhookXml)
            where TEvent : BaiduSmartAppOpenApiEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            try
            {
                if (webhookXml.Contains("<Encrypt>") && webhookXml.Contains("</Encrypt>"))
                {
                    XDocument xDoc = XDocument.Parse(webhookXml);
                    string? msgEncrypt = xDoc.Root?.Element("Encrypt")?.Value;

                    if (string.IsNullOrEmpty(msgEncrypt))
                        throw new BaiduSmartAppException("Failed to decrypt event data, because the encrypted data is empty.");

                    webhookXml = Utilities.BaiduMsgCryptor.AESDecrypt(cipherText: msgEncrypt!, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return (TEvent)_XmlSimpleSerializer.Deserialize(webhookXml, typeof(TEvent));
            }
            catch (BaiduSmartAppException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new BaiduSmartAppException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }
    }
}
