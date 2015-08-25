using System;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPIInvalidKeyException : AlchemyAPIServiceCallException
    {
        public AlchemyAPIInvalidKeyException() : base(AlchemyAPIClientResources.invalid_key_error) { }
    }
}
