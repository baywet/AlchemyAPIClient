using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyFeedRequestBase : AlchemyRequestBase<AlchemyFeed, AlchemyFeedResponse>, ICombinableAlchemyAPIRequest
    {
        protected const string urlKey = "url";
        public AlchemyFeedRequestBase(AlchemyClient client) : base(client)
        {

        }
        public string CallName
        {
            get
            {
                return "feed";
            }
        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
    }
}
