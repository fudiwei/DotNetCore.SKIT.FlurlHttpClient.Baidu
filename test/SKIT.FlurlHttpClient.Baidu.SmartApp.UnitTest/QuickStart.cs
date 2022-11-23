using Microsoft.VisualStudio.TestTools.UnitTesting;
using SKIT.FlurlHttpClient.Baidu.SmartApp.Events;
using SKIT.FlurlHttpClient.Baidu.SmartApp.Models;
using SKIT.FlurlHttpClient.Baidu.SmartApp.Utilities;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.UnitTest
{
    [TestClass]
    public class QuickStart
    {
        [TestMethod]
        public void TestPushTicket()
        {
            var options = new SmartAppClientOptions
            {
                AppId = "",
                AppKey = "",
                AppSecret = "",
                VerifyToken = "",
                EncryptKey = "",
            };
            var baiduClient = new SmartAppThirdPartyClient(options);

            var data = new
            {
                Nonce = "",
                TimeStamp = 0,
                Encrypt = "",
                MsgSignature = ""
            };

            bool verify = baiduClient.VerifySignature(data.TimeStamp.ToString(), data.Nonce, data.Encrypt, data.MsgSignature);
            Assert.IsTrue(verify);

            var appEvent = baiduClient.DecryptEvent<SmartAppEvent>(data.Encrypt);
            Assert.IsNotNull(appEvent);
            Assert.AreEqual(appEvent.AppId, baiduClient.Credentials.AppId);

            var kvs = appEvent.ToDictionary();
            Assert.IsTrue(kvs.Any(x => x.Key == "MsgType"));

            var ticket = appEvent.ToEvent<PushTicketEvent>();
            Assert.IsNotNull(ticket);
            Assert.IsFalse(string.IsNullOrWhiteSpace(ticket.Ticket));
        }
    }
}
