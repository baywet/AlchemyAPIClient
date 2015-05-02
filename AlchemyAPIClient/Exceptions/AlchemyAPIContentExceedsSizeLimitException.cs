using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlchemyAPIClient.Exceptions
{
    public class AlchemyAPIContentExceedsSizeLimitException : AlchemyAPIServiceCallException
    {
        public AlchemyAPIContentExceedsSizeLimitException() : base(AlchemyAPIClientResources.content_exceeds_size_error) { }
    }
}
