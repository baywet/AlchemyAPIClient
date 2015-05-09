using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPIInvalidKeyException : AlchemyAPIServiceCallException
    {
        internal AlchemyAPIInvalidKeyException() : base(AlchemyAPIClientResources.invalid_key_error) { }
    }
}
