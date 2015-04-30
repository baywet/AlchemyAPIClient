using AlchemyAPIClient.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyAuthorsRequestBase : AlchemyRequestBase<AlchemyAuthors, AlchemyAuthorsResponse>
    {
        protected const string urlKey = "url";
        public AlchemyAuthorsRequestBase(AlchemyClient client)
            : base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
    }
}
