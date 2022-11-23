using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp
{
    public abstract class SmartAppResponse : ICommonResponse
    {
        int ICommonResponse.RawStatus { get; set; }

        IDictionary<string, string> ICommonResponse.RawHeaders { get; set; }

        byte[] ICommonResponse.RawBytes { get; set; }


        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int RawStatus { get => ((ICommonResponse)this).RawStatus; internal set { ((ICommonResponse)this).RawStatus = value; } }

        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IDictionary<string, string> RawHeaders { get => ((ICommonResponse)this).RawHeaders; internal set { ((ICommonResponse)this).RawHeaders = value; } }

        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] RawBytes { get => ((ICommonResponse)this).RawBytes; internal set { ((ICommonResponse)this).RawBytes = value; } }


        /// <summary>
        /// 获取一个值，该值指示调用百度 API 是否成功（即 HTTP 状态码为 200、且 errno 值为 0）。
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSuccessful()
        {
            return RawStatus == 200 && ErrNo == 0;
        }

        [Newtonsoft.Json.JsonProperty("errno")]
        [System.Text.Json.Serialization.JsonPropertyName("errno")]
        public virtual int ErrNo { get; set; }

        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public virtual string Message { get; set; }


        [Newtonsoft.Json.JsonProperty("error_code")]
        [System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public virtual int ErrorCode { get => this.ErrNo; set { this.ErrNo = value; } }

        [Newtonsoft.Json.JsonProperty("error_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("error_msg")]
        public virtual string ErrorMessage { get => this.Message; set { this.Message = value; } }
    }

    public class SmartAppResponse<T> : SmartAppResponse
    {
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public T Data { get; set; }
    }
}
