using System;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPICannotRetrieveException : AlchemyAPIServiceCallException
    {
        public AlchemyAPICannotRetrieveException() : base(AlchemyAPIClientResources.cannot_retrieve_error) { }
    }
}
