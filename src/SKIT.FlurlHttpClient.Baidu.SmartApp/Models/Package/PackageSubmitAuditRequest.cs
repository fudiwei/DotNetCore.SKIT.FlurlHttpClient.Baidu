using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Models.Package
{
    public class PackageSubmitAuditRequest : SmartAppRequest
    {
        /// <summary>
        /// 送审描述
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 包 id
        /// </summary>
        public string PackageId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 测试帐号
        /// </summary>
        public string TestAccount { get; set; }

        /// <summary>
        /// 测试帐号对应的密码
        /// </summary>
        public string TestPassword { get; set; }
    }
}
