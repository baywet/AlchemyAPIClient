using System;

namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyUrlTitleRequest : AlchemyTitleRequestBase, IAlchemyAPIUrlRequest, ICombinableAlchemyAPIRequest, IAlchemyAPIUrlCombinableRequest
    {
        public AlchemyUrlTitleRequest(Uri url, AlchemyClient client):base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetTitle"; }
        }
    }
}
