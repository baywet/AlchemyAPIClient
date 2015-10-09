using System;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPIUnsupportedLanguageException : AlchemyAPIServiceCallException
    {
        public AlchemyAPIUnsupportedLanguageException() : base(AlchemyAPIClientResources.unsupported_language_error) { }
    }
}
