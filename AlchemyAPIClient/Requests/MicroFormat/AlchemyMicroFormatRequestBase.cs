using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyMicroFormatRequestBase : AlchemyRequestBase<AlchemyMicroFormat, AlchemyMicroFormatResponse>
    {
        protected const string urlKey = "url";
        public AlchemyMicroFormatRequestBase(AlchemyClient client) : base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
    }
}
