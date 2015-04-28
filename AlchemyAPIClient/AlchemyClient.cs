
namespace AlchemyAPIClient
{
    public class AlchemyClient
    {
        public string EndPointUrl { get; private set; }
        public string EndPointKey { get; private set; }
        public AlchemyClient(string endPointKey, string endPointUrl = "http://access.alchemyapi.com/calls/")
        {
            EndPointUrl = endPointUrl;
            EndPointKey = endPointKey;
        }
    }
}
