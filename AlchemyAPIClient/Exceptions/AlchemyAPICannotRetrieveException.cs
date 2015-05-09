using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPICannotRetrieveException : AlchemyAPIServiceCallException
    {
        internal AlchemyAPICannotRetrieveException() : base(AlchemyAPIClientResources.cannot_retrieve_error) { }
    }
}
