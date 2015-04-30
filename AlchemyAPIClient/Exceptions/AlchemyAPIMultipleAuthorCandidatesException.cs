using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlchemyAPIClient.Exceptions
{
    public class AlchemyAPIMultipleAuthorCandidatesException : AlchemyAPIServiceCallException
    {
        public AlchemyAPIMultipleAuthorCandidatesException() : base(AlchemyAPIClientResources.multiple_author_candidates_error) { }
    }
}
