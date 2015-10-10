
namespace AlchemyAPIClient
{
    public class AlchemyClient
    {
        public string EndPointUrl { get; private set; }
        public string EndPointKey { get; private set; }
        public int MaxRetriesWhenTimeOut { get; set; } = 3;
        public int RetryWaitTimeForNetworkErrorsInMS { get; set; } = 100;
        public AlchemyClient(string endPointKey, string endPointUrl = "https://access.alchemyapi.com/calls/")
        {
            EndPointUrl = endPointUrl;
            EndPointKey = endPointKey;
        }
    }
}
