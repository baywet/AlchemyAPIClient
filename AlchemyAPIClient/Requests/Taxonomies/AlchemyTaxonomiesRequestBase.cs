using AlchemyAPIClient.Responses;
using System;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyTaxonomiesRequestBase : AlchemyRequestBase<AlchemyTaxonomy, AlchemyTaxonomiesResponse>, ICombinableAlchemyAPIRequest
    {
        protected const string urlKey = "url";
        private const string baseUrlKey = "baseUrl";
        public AlchemyTaxonomiesRequestBase(AlchemyClient client):base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
        public Uri BaseUrl { get { return GetUriParameter(baseUrlKey); } set { AddOrUpdateParameter(baseUrlKey, value); } }
        public string CallName
        {
            get
            {
                return "taxonomy";
            }
        }
    }
}
