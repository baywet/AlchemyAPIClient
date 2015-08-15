using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyLanguageRequestBase : AlchemyRequestBase<string, AlchemyLanguageResponse>
    {
        protected const string urlKey = "url";
        public AlchemyLanguageRequestBase(AlchemyClient client):base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
    }
}
