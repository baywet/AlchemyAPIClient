using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyAPICombinedResponse : AlchemyResponseBase<IEnumerable<AlchemyResponseBase<object>>>
    {
        public AlchemyAuthorResponse AuthorResponse { get; set; }
    }
}
