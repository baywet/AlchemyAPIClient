using System;

namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyUrlRelationsRequest : AlchemyHtmlRelationsRequestBase, IAlchemyAPIUrlRequest, ICombinableAlchemyAPIRequest, IAlchemyAPIUrlCombinableRequest
    {
        public AlchemyUrlRelationsRequest(Uri url, AlchemyClient client):base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetRelations"; }
        }
    }
}
