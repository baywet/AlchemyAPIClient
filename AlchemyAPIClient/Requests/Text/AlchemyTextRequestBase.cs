using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyTextRequestBase : AlchemyRequestBase<string, AlchemyTextResponse>
    {
        protected const string urlKey = "url";
        public AlchemyTextRequestBase(AlchemyClient client)
            : base(client)
        {
            
        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
    }
}
