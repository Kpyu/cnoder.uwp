using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cnoder.uwp.Helper
{
    public class HttpHelper
    {
        public static HttpHelper Factory
        {
            get
            {
                return new HttpHelper();
            }
        }
        public HttpRequestMessage CreateRequest(HttpMethod method, string uri, params KeyValuePair<string, string>[] keyValueCollection)
        {
            return CreateRequest(method, new Uri(uri), keyValueCollection);
        }

        private HttpRequestMessage CreateRequest(HttpMethod method, Uri uri, KeyValuePair<string, string>[] keyValueCollection)
        {
            var request = new HttpRequestMessage(method, uri);
            request.Content = new FormUrlEncodedContent(keyValueCollection);
            return request;
        }
    }
}
