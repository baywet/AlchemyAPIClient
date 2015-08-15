using System;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPIContentExceedsSizeLimitException : AlchemyAPIServiceCallException
    {
        public AlchemyAPIContentExceedsSizeLimitException() : base(AlchemyAPIClientResources.content_exceeds_size_error) { }
    }
}
