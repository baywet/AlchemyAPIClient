using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPICannotRetrieveDNSTimeoutException : AlchemyAPIServiceCallException
    {
        public AlchemyAPICannotRetrieveDNSTimeoutException() : base(AlchemyAPIClientResources.cannot_retrieve_dns_timeout) { }
    }
}
