using System.Text;
using System.Web;

namespace SKIT.FlurlHttpClient.Baidu.Push.Utilities
{
    internal static class QuirksUrlEncoder
    {
        public static string Encode(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            StringBuilder builder = new StringBuilder();

            foreach (char c in value)
            {
                string r;

                if (c == '!')
                {
                    r = "%21";
                }
                else if (c == '\'')
                {
                    r = "%27";
                }
                else if (c == '(')
                {
                    r = "%28";
                }
                else if (c == ')')
                {
                    r = "%29";
                }
                else if (c == '*')
                {
                    r = "%2A";
                }
                else if (c == '~')
                {
                    r = "%7E";
                }
                else if (c == ' ')
                {
                    r = "+";
                }
                else
                {
                    r = HttpUtility.UrlEncode(c.ToString());
                    if (r.Length > 1)
                        r = r.ToUpper();
                }

                builder.Append(r);
            }

            return builder.ToString();
        }
    }
}
