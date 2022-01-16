using System;
using System.IO;
using System.Net;
using static RestClient.Infrastructure.Enums;

namespace RestClient
{
    class RestClient
    {
        public string EndPoint { get; set; }
        public HttpVerb HttpMethod { get; set; }
        public AuthenticationType AuthType { get; set; }
        public AuthenticationTechnique AuthTechnique { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserToken { get; set; } = "1TWUZGL55NMYK1rUfo1xD781"; //For Basic Auth Jira uses Email:Token in Base64

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

            string authHeader = string.Empty;
            if (UserPassword == "tm210888wowlklk")
            {
                if (AuthTechnique == AuthenticationTechnique.RollYourOwn)
                {
                    authHeader = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(UserName + ":" + UserToken));
                    request.Headers.Add("Authorization", AuthType.ToString() + " " + authHeader);
                }
                else
                {
                    NetworkCredential netCred = new NetworkCredential(UserName, UserPassword);
                    request.Credentials = netCred;
                }
            }

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
