namespace RestClient.Infrastructure
{
    public class Enums
    {
        public enum HttpVerb
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public enum AuthenticationType
        {
            Basic,
            NLTM
        }

        public enum AuthenticationTechnique
        {
            RollYourOwn,
            NetworkCredential
        }
    }
}
