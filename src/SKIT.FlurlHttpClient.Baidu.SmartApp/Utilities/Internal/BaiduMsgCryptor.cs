using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace SKIT.FlurlHttpClient.Baidu.SmartApp.Utilities
{
    internal static class BaiduMsgCryptor
    {
        private const int AES_KEY_SIZE = 256;
        private const int AES_BLOCK_SIZE = 128;

        private static char ConvertToChar(int i)
        {
            byte ret = (byte)(i & 0xFF);
            return (char)ret;
        }

        private static byte[] KCS7Encoder(int len)
        {
            if (len <= 0) throw new ArgumentOutOfRangeException(nameof(len));

            const int BLOCK_SIZE = 32;

            int paddingLength = BLOCK_SIZE - (len % BLOCK_SIZE);
            if (paddingLength == 0)
            {
                paddingLength = BLOCK_SIZE;
            }

            char paddingChar = ConvertToChar(paddingLength);
            string tmp = string.Empty;
            for (int index = 0; index < paddingLength; index++)
            {
                tmp += paddingChar;
            }

            return Encoding.UTF8.GetBytes(tmp);
        }

        private static string CreateRandCode(int len)
        {
            if (len <= 0) throw new ArgumentOutOfRangeException(nameof(len));

            Random random = new Random(unchecked((int)DateTime.Now.Ticks));
            string[] source = "2,3,4,5,6,7,a,c,d,e,f,h,i,j,k,m,n,p,r,s,t,A,C,D,E,F,G,H,J,K,M,N,P,Q,R,S,U,V,W,X,Y,Z".Split(',');
            string result = string.Empty;
            for (int i = 0; i < len; i++)
            {
                int randval = random.Next(0, source.Length - 1);
                result += source[randval];
            }

            return result;
        }

        private static byte[] Decode2(byte[] decryptedBytes)
        {
            if (decryptedBytes == null) throw new ArgumentNullException(nameof(decryptedBytes));

            int pad = (int)decryptedBytes[decryptedBytes.Length - 1];
            if (pad < 1 || pad > 32)
            {
                pad = 0;
            }

            byte[] res = new byte[decryptedBytes.Length - pad];
            Array.Copy(decryptedBytes, 0, res, 0, decryptedBytes.Length - pad);
            return res;
        }

        private static byte[] AESDecrypt(byte[] keyBytes, byte[] ivBytes, byte[] cipherBytes)
        {
            if (keyBytes == null) throw new ArgumentNullException(nameof(keyBytes));
            if (ivBytes == null) throw new ArgumentNullException(nameof(ivBytes));
            if (cipherBytes == null) throw new ArgumentNullException(nameof(cipherBytes));

            using var aes = Aes.Create();
            aes.KeySize = AES_KEY_SIZE;
            aes.BlockSize = AES_BLOCK_SIZE;
            aes.Mode = CipherMode.CBC;
            //aes.Padding = PaddingMode.PKCS7;
            aes.Padding = PaddingMode.None;
            aes.Key = keyBytes;
            aes.IV = ivBytes;

            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
            using (var ms = new MemoryStream())
            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
            {
                byte[] msgBytes = new byte[cipherBytes.Length + 32 - cipherBytes.Length % 32];
                Array.Copy(cipherBytes, msgBytes, cipherBytes.Length);
                cs.Write(cipherBytes, 0, cipherBytes.Length);

                byte[] plainBytes = Decode2(ms.ToArray());
                return plainBytes;
            }
        }

        private static string AESEncrypt(byte[] keyBytes, byte[] ivBytes, byte[] plainBytes)
        {
            if (keyBytes == null) throw new ArgumentNullException(nameof(keyBytes));
            if (ivBytes == null) throw new ArgumentNullException(nameof(ivBytes));
            if (plainBytes == null) throw new ArgumentNullException(nameof(plainBytes));

            using var aes = Aes.Create();
            aes.KeySize = AES_KEY_SIZE;
            aes.BlockSize = AES_BLOCK_SIZE;
            //aes.Padding = PaddingMode.PKCS7;
            aes.Padding = PaddingMode.None;
            aes.Mode = CipherMode.CBC;
            aes.Key = keyBytes;
            aes.IV = ivBytes;

            byte[] msgBytes = new byte[plainBytes.Length + 32 - plainBytes.Length % 32];
            Array.Copy(plainBytes, msgBytes, plainBytes.Length);
            byte[] padBytes = KCS7Encoder(plainBytes.Length);
            Array.Copy(padBytes, 0, msgBytes, plainBytes.Length, padBytes.Length);

            using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
            using (var ms = new MemoryStream())
            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
            {
                cs.Write(msgBytes, 0, msgBytes.Length);
                byte[] cipherBytes = ms.ToArray();
                return Convert.ToBase64String(cipherBytes);
            }
        }

        public static string AESDecrypt(string cipherText, string encodingAESKey, out string appId)
        {
            if (cipherText == null) throw new ArgumentNullException(nameof(cipherText));
            if (encodingAESKey == null) throw new ArgumentNullException(nameof(encodingAESKey));

            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] keyBytes = Convert.FromBase64String(encodingAESKey + "=");
            byte[] ivBytes = new byte[16];
            Array.Copy(keyBytes, ivBytes, 16);
            byte[] btmpMsg = AESDecrypt(cipherBytes: cipherBytes, ivBytes: ivBytes, keyBytes: keyBytes);

            int len = BitConverter.ToInt32(btmpMsg, 16);
            len = IPAddress.NetworkToHostOrder(len);

            byte[] bMsg = new byte[len];
            byte[] bCorpId = new byte[btmpMsg.Length - 20 - len];
            Array.Copy(btmpMsg, 20, bMsg, 0, len);
            Array.Copy(btmpMsg, 20 + len, bCorpId, 0, btmpMsg.Length - 20 - len);

            appId = Encoding.UTF8.GetString(bCorpId);
            return Encoding.UTF8.GetString(bMsg);
        }

        public static string AESEncrypt(string plainText, string encodingAESKey, string appId)
        {
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));
            if (encodingAESKey == null) throw new ArgumentNullException(nameof(encodingAESKey));
            if (appId == null) throw new ArgumentNullException(nameof(appId));

            byte[] keyBytes = Convert.FromBase64String(encodingAESKey + "=");
            byte[] ivBytes = new byte[16];
            Array.Copy(keyBytes, ivBytes, 16);

            string randCode = CreateRandCode(16);
            byte[] bRand = Encoding.UTF8.GetBytes(randCode);
            byte[] bCorpId = Encoding.UTF8.GetBytes(appId);
            byte[] bMsgTmp = Encoding.UTF8.GetBytes(plainText);
            byte[] bMsgLen = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(bMsgTmp.Length));
            byte[] bMsg = new byte[bRand.Length + bMsgLen.Length + bCorpId.Length + bMsgTmp.Length];

            Array.Copy(bRand, bMsg, bRand.Length);
            Array.Copy(bMsgLen, 0, bMsg, bRand.Length, bMsgLen.Length);
            Array.Copy(bMsgTmp, 0, bMsg, bRand.Length + bMsgLen.Length, bMsgTmp.Length);
            Array.Copy(bCorpId, 0, bMsg, bRand.Length + bMsgLen.Length + bMsgTmp.Length, bCorpId.Length);

            return AESEncrypt(keyBytes: keyBytes, ivBytes: ivBytes, plainBytes: bMsg);
        }

        public static bool VerifySignature(string sToken, string sTimestamp, string sNonce, string sMsgEncrypt, string sMsgSign)
        {
            if (sToken == null) throw new ArgumentNullException(nameof(sToken));
            if (sTimestamp == null) throw new ArgumentNullException(nameof(sTimestamp));
            if (sNonce == null) throw new ArgumentNullException(nameof(sNonce));
            if (sMsgEncrypt == null) throw new ArgumentNullException(nameof(sMsgEncrypt));
            if (sMsgSign == null) throw new ArgumentNullException(nameof(sMsgSign));

            string expectedSign = GenerateSignature(sToken, sTimestamp, sNonce, sMsgEncrypt);
            return string.Equals(expectedSign, sMsgSign, StringComparison.OrdinalIgnoreCase);
        }

        public static string GenerateSignature(string sToken, string sTimestamp, string sNonce, string sMsgEncrypt)
        {
            if (sToken == null) throw new ArgumentNullException(nameof(sToken));
            if (sTimestamp == null) throw new ArgumentNullException(nameof(sTimestamp));
            if (sNonce == null) throw new ArgumentNullException(nameof(sNonce));
            if (sMsgEncrypt == null) throw new ArgumentNullException(nameof(sMsgEncrypt));

            ISet<string> set = new SortedSet<string>(StringComparer.Ordinal);
            set.Add(sToken);
            set.Add(sTimestamp);
            set.Add(sNonce);
            set.Add(sMsgEncrypt);

            string rawText = string.Join(string.Empty, set.ToArray());
            string signText = Utilities.SHA1Utility.Hash(rawText);
            return signText.ToLower();
        }
    }
}
