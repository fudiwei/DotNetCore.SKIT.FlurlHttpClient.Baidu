using Newtonsoft.Json;
using SKIT.FlurlHttpClient.Baidu.SmartApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp
{
    public static class SmartAppClientEventExtensions
    {
        public static T DecryptEvent<T>(this SmartAppThirdPartyClient client, string encryptText) where T : SmartAppEvent, new()
        {
            var decryptData = SmartAppEventDataCryptor.AESDecrypt(encryptText, client.Credentials.EncryptKey, out string appId);

            var data = JsonConvert.DeserializeObject<T>(decryptData);
            if (data != null)
            {
                data.DecryptData = decryptData;

                if (string.IsNullOrWhiteSpace(data.TpAppId))
                    data.TpAppId = appId;
            }

            return data;
        }

        public static T ToEvent<T>(this SmartAppEvent e) where T : SmartAppEvent, new()
        {
            var data = JsonConvert.DeserializeObject<T>(e.DecryptData);
            if (data == null)
                return null;

            data.DecryptData = e.DecryptData;
            if (string.IsNullOrWhiteSpace(data.TpAppId))
                data.TpAppId = e.TpAppId;

            return data;
        }

        public static bool VerifySignature(this SmartAppThirdPartyClient client, string timestamp, string nonce, string encrypt, string msgSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (timestamp == null) throw new ArgumentNullException(nameof(timestamp));
            if (nonce == null) throw new ArgumentNullException(nameof(nonce));
            if (encrypt == null) throw new ArgumentNullException(nameof(encrypt));
            if (msgSignature == null) throw new ArgumentNullException(nameof(msgSignature));

            ISet<string> set = new SortedSet<string>(StringComparer.Ordinal) { client.Credentials.VerifyToken!, timestamp, nonce, encrypt };
            string sign = Utilities.SHA1Utility.Hash(string.Concat(set));
            return string.Equals(sign, msgSignature, StringComparison.OrdinalIgnoreCase);
        }
    }
}
