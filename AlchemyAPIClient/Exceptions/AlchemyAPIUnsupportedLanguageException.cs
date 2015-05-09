using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Exceptions
{
    [Serializable]
    public class AlchemyAPIUnsupportedLanguageException : AlchemyAPIServiceCallException
    {
        internal AlchemyAPIUnsupportedLanguageException() : base(AlchemyAPIClientResources.unsupported_language_error) { }
    }
}
