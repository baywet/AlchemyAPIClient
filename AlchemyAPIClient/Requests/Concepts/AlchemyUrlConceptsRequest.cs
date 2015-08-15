using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlConceptsRequest : AlchemyHtmlConceptsRequestBase, IAlchemyAPIUrlRequest, ICombinableAlchemyAPIRequest, IAlchemyAPIUrlCombinableRequest
    {
        protected const string baseUrlKey = "baseUrl";
        public AlchemyUrlConceptsRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetRankedConcepts"; }
        }
        public Uri BaseUrl { get { return GetUriParameter(baseUrlKey); } set { AddOrUpdateParameter(baseUrlKey, value); } }
    }
}
