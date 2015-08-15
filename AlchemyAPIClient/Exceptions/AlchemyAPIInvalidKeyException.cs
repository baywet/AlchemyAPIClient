using System;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPIInvalidKeyException : AlchemyAPIServiceCallException
    {
        internal AlchemyAPIInvalidKeyException() : base(AlchemyAPIClientResources.invalid_key_error) { }
    }
}
