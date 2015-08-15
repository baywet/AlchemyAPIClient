using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyAuthorRequestBase : AlchemyRequestBase<string, AlchemyAuthorResponse>, ICombinableAlchemyAPIRequest
    {
        protected const string urlKey = "url";
        public AlchemyAuthorRequestBase(AlchemyClient client)
            : base(client)
        {

        }
        public string CallName
        {
            get
            {
                return "author";
            }
        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
    }
}
