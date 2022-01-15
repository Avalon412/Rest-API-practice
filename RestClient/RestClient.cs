using System;
using System.IO;
using System.Net;

namespace RestClient
{
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RestClient
    {
        public string EndPoint { get; set; }
        public HttpVerb HttpMethod { get; set; }

        public RestClient()
        {
            EndPoint = string.Empty;
            HttpMethod = HttpVerb.GET;
        }

        public string MakeRequest()
        {
            string responseValue = string.Empty;

            HttpWebRequest request = WebRequest.Create(EndPoint) as HttpWebRequest;
            request.Method = HttpMethod.ToString();

            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if(response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code:" + response.StatusCode);
                }
                //Process the response stream...

                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                    }
                }
                //End of using ResponseStream
            }

            return responseValue;
        }
    }
}
