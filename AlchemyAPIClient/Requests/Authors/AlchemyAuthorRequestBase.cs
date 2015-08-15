using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyAuthorRequestBase : AlchemyRequestBase<string, AlchemyAuthorResponse>
    {
        protected const string urlKey = "url";
        public AlchemyAuthorRequestBase(AlchemyClient client)
            : base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
    }
}
