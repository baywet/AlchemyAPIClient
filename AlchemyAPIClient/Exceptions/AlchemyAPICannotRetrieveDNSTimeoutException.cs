using System;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPICannotRetrieveDNSTimeoutException : AlchemyAPIServiceCallException
    {
        public AlchemyAPICannotRetrieveDNSTimeoutException() : base(AlchemyAPIClientResources.cannot_retrieve_dns_timeout) { }
    }
}
