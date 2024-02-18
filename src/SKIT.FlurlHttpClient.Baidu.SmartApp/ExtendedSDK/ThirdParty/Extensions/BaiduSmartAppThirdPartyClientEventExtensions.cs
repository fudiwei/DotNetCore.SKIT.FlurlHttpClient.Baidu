using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.ExtendedSDK.ThirdParty
{
    using SKIT.FlurlHttpClient.Primitives;

    public static partial class BaiduSmartAppThirdPartyClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="BaiduSmartAppThirdPartyEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this BaiduSmartAppThirdPartyClient client, string webhookJson)
            where TEvent : BaiduSmartAppThirdPartyEvent, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="BaiduSmartAppThirdPartyEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static BaiduSmartAppThirdPartyEvent DeserializeEventFromJson(this BaiduSmartAppThirdPartyClient client, string webhookJson)
        {
            return InnerDeserializeEventFromJson<BaiduSmartAppThirdPartyEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>验证消息推送事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://smartprogram.baidu.com/docs/third/customer/customerability/ ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">百度消息推送中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">百度消息推送中的 "nonce" 查询参数。</param>
        /// <param name="webhookSignature">百度消息推送中的 "signature" 查询参数。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureForEcho(this BaiduSmartAppThirdPartyClient client, string webhookTimestamp, string webhookNonce, string webhookSignature)
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
        /// <para>验证消息推送事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://smartprogram.baidu.com/docs/third/push/encryption/ ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson">百度消息推送中请求正文（JSON 格式）。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignature(this BaiduSmartAppThirdPartyClient client, string webhookJson)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(webhookJson);
                bool valid = Utilities.BaiduMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: encryptedEvent.TimestampString,
                    sNonce: encryptedEvent.Nonce,
                    sMsgEncrypt: encryptedEvent.EncryptedData,
                    sMsgSign: encryptedEvent.Signature
                );

                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{encryptedEvent.Signature}\" is an illegal signature."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }
    }

    partial class BaiduSmartAppThirdPartyClientEventExtensions
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

        private static TEvent InnerDeserializeEventFromJson<TEvent>(BaiduSmartAppThirdPartyClient client, string webhookJson)
            where TEvent : BaiduSmartAppThirdPartyEvent
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
    }
}
