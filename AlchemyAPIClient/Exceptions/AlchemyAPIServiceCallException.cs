using System;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPIServiceCallException : Exception
    {
        internal static AlchemyAPIServiceCallException GetValidException(string subStatus)
        {
            switch (subStatus)
            {
                case "invalid-api-key":
                    return new AlchemyAPIInvalidKeyException();
                case "cannot-retrieve":
                    return new AlchemyAPICannotRetrieveException();
                case "page-is-not-html":
                    return new AlchemyAPIPageNotHTMLException();
                case "unsupported-text-language":
                    return new AlchemyAPIUnsupportedLanguageException();
                case "author-not-found:cannot-locate":
                    return new AlchemyAPICannotLocateAuthorException();
                case "author-not-found:multiple-candidates":
                    return new AlchemyAPIMultipleAuthorCandidatesException();
                case "content-exceeds-size-limit":
                    return new AlchemyAPIContentExceedsSizeLimitException();
                case "cannot-retrieve:operation-timeout:cannot-resolve-dns":
                    return new AlchemyAPICannotRetrieveDNSTimeoutException();
                case "daily-transaction-limit-exceeded":

                default:
                    return new AlchemyAPIServiceCallException(subStatus);
            }
        }
        internal AlchemyAPIServiceCallException(string message)
            : base(message)
        { }
    }
}
