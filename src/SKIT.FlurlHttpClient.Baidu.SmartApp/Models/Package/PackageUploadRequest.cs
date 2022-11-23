using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Package
{
    public class PackageUploadRequest : SmartAppRequest
    {
        /// <summary>
        /// 第三方自定义的配置
        /// </summary>
        public string ExtJson { get; set; }

        /// <summary>
        /// 代码库中的代码模板 id ，可以在第三方平台-模板管理-模板库 查看到模板 id
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// 代码描述，开发者可自定义
        /// </summary>
        public string UserDesc { get; set; }

        /// <summary>
        /// 代码版本号，开发者可自定义
        /// </summary>
        public string UserVersion { get; set; }

        /// <summary>
        /// 设置直接送审( ext_json 中的 directCommit 字段为 true 时)，可以向审核人员提供的测试帐号
        /// </summary>
        public string TestAccount { get; set; }

        /// <summary>
        /// 测试帐号对应的密码
        /// </summary>
        public string TestPassword { get; set; }
    }
}
