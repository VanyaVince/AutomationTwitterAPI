using System;
using System.Security.Cryptography;
using System.Text;

namespace Twitter
{
    public class AutorizationHeaderBulder
    {
        private string _oauthConsumerKey = "inzRlX2V0NSfGC32A4YugXQQU";
        private string _oauthConsumerSecret = "TLOdL9hLyocunIhPOqHdNtIWlWLc1C7ztNEO1B6cYqu2BvahSC";
        private string _oauthAccessToken = "1488147999423447042-2V6rFID8gKbSTAAkw3Q11OFfutRijO";
        private string _oauthTokenSecret = "lgnOMnDmjYh3HYpOD3OIFn1758IjqwHlthNDcw5Iy2PIQ";

        public string _oauth_signature_method = "HMAC-SHA1";
        public string _oauthVersionMethod = "1.0";
        public string _oauthUrl;

        public AutorizationHeaderBulder(string oauthUrl)
        {
            _oauthUrl = oauthUrl;
        }

        public string GenerateAuthorizationHeader(string oauthNonce, string oauthTimestamp, string oauthSignature)
        {
            string authorizationFormat = "OAuth oauth_consumer_key=\"{0}\", oauth_nonce=\"{1}\", " + "oauth_signature=\"{2}\", oauth_signature_method=\"{3}\", " + "oauth_timestamp=\"{4}\", oauth_token=\"{5}\", " + "oauth_version=\"{6}\"";

            string authorizationHeader = string.Format(
                authorizationFormat,
                _oauthConsumerKey.EncodeDataString(),
                oauthNonce.EncodeDataString(),
                oauthSignature.EncodeDataString(),
                _oauth_signature_method.EncodeDataString(),
                oauthTimestamp.EncodeDataString(),
                _oauthAccessToken.EncodeDataString(),
                _oauthVersionMethod.EncodeDataString()
            );

            return authorizationHeader;
        }

        public string GenerateTweetSignature(string message, string oauth_nonce, string oauth_timestamp)
        {
            string baseFormat = "oauth_consumer_key={0}&oauth_nonce={1}&oauth_signature_method={2}" + "&oauth_timestamp={3}&oauth_token={4}&oauth_version={5}&status={6}";

            string baseString = string.Format(
                baseFormat,
                _oauthConsumerKey,
                oauth_nonce,
                _oauth_signature_method,
                oauth_timestamp,
                _oauthAccessToken,
                _oauthVersionMethod,
                message.EncodeDataString()
            );

            HMACSHA1 hasher = new HMACSHA1(Encoding.ASCII.GetBytes(_oauthConsumerSecret.EncodeDataString() + "&" + _oauthTokenSecret.EncodeDataString()));
            string oauthSignature = Convert.ToBase64String(hasher.ComputeHash(Encoding.ASCII.GetBytes("POST&" + _oauthUrl.EncodeDataString() + "&" + baseString.EncodeDataString())));

            return oauthSignature;
        }
    }
}
