using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlEntitiesRequest : AlchemyHtmlEntitiesRequestBase, IAlchemyAPIUrlRequest, ICombinableAlchemyAPIRequest, IAlchemyAPIUrlCombinableRequest
    {
        protected override string RequestPath
        {
            get { return "url/URLGetRankedNamedEntities"; }
        }
        public AlchemyUrlEntitiesRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
    }
}
