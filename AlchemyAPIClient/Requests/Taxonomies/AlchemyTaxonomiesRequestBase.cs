using AlchemyAPIClient.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemyTaxonomiesRequestBase : AlchemyRequestBase<AlchemyTaxonomy, AlchemyTaxonomiesResponse>
    {
        protected const string urlKey = "url";
        protected const string baseUrlKey = "baseUrl";
        public AlchemyTaxonomiesRequestBase(AlchemyClient client):base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
        public Uri BaseUrl { get { return GetUriParameter(baseUrlKey); } set { AddOrUpdateParameter(baseUrlKey, value); } }
    }
}
