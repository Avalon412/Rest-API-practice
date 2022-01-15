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

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
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
            catch (Exception ex)
            {
                responseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}"; 
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

            return responseValue;
        }
    }
}
