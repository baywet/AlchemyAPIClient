using System;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPIUnsupportedLanguageException : AlchemyAPIServiceCallException
    {
        internal AlchemyAPIUnsupportedLanguageException() : base(AlchemyAPIClientResources.unsupported_language_error) { }
    }
}
