using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Exceptions
{
    public class AlchemyAPIServiceCallException : Exception
    {
        internal static AlchemyAPIServiceCallException GetValidException(string subStatus)
        {
            switch(subStatus)
            {
                case "invalid-api-key":
                    return new AlchemyAPIInvalidKeyException();
                case "cannot-retrieve":
                    return new AlchemyAPICannotRetrieveException();
                case "page-is-not-html":
                    return new AlchemyAPIPageNotHTMLException();
                case "unsupported-text-language":
                    return new AlchemyAPIUnsupportedLanguageException();
                default:
                    return new AlchemyAPIServiceCallException(subStatus);
            }
        }
        internal AlchemyAPIServiceCallException(string message)
            : base(message)
        { }
    }
}
