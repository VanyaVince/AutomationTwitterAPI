using System.Net;
using System.Text;

namespace Twitter
{
    public class TwitterAPI
    {
        private string _oauthUrl;
        private readonly AutorizationHeaderBulder _oauthBuilder;

        public TwitterAPI(string oauthUrl)
        {
            _oauthBuilder = new AutorizationHeaderBulder(oauthUrl);
            _oauthUrl = oauthUrl;
        }

        public void SendTweet(string message)
        {
            var autorizationHeader = GetAuthorizationHeaderForTweet(message);
            var request = GenerateHttpRequest(autorizationHeader, HttpMethod.POST, HttpContentType.Urlencoded);

            var bodyRequst = string.Format("status={0}", message.EncodeDataString());
            WriteRequsetBody(request, bodyRequst);

            WebResponse response = request.GetResponse();
            response.Close();
        }
        
        private HttpWebRequest GenerateHttpRequest(string authHeader, string method, string contentType)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_oauthUrl);
            request.Headers.Add("Authorization", authHeader);
            request.Method = method;
            request.ContentType = contentType;

            return request;
        }

        private string GetAuthorizationHeaderForTweet(string message)
        {
            string oauth_nonce = SystemHelper.GetRandomValue();
            string oauth_timestamp = SystemHelper.GetTimestamp();
            string oauth_signature = _oauthBuilder.GenerateTweetSignature(message, oauth_nonce, oauth_timestamp);
            string authorizationValueHeader = _oauthBuilder.GenerateAuthorizationHeader(oauth_nonce, oauth_timestamp, oauth_signature);

            return authorizationValueHeader;
        }

        private void WriteRequsetBody(HttpWebRequest request, string body) 
        {
            var requestBody = Encoding.ASCII.GetBytes(body);

            using(var stream = request.GetRequestStream())
            {
                stream.Write(requestBody, 0, requestBody.Length);
            }
        }
    }
}