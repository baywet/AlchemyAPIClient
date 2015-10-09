using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyPublicationDateRequestBase : AlchemyRequestBase<AlchemyPublicationDate, AlchemyPublicationDateResponse>, ICombinableAlchemyAPIRequest
    {
        protected const string urlKey = "url";
        public AlchemyPublicationDateRequestBase(AlchemyClient client):base(client)
        {

        }
        public string CallName
        {
            get
            {
                return "pub-date";
            }
        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
    }
}
