using System;

namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyUrlKeywordsRequest : AlchemyHtmlKeywordsRequestBase, IAlchemyAPIUrlRequest, ICombinableAlchemyAPIRequest, IAlchemyAPIUrlCombinableRequest
    {
        public AlchemyUrlKeywordsRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetRankedKeywords"; }
        }
    }
}
