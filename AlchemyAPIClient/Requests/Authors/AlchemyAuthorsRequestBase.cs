using AlchemyAPIClient.Responses;
using System;

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
