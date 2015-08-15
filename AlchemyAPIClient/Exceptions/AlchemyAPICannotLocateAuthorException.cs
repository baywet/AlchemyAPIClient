using System;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPICannotLocateAuthorException : AlchemyAPIServiceCallException
    {
        public AlchemyAPICannotLocateAuthorException() : base(AlchemyAPIClientResources.cannot_locate_author_error) { }
    }
}
