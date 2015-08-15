using System;

namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyUrlSentimentRequest : AlchemyHtmlSentimentBase, IAlchemyAPIUrlRequest, ICombinableAlchemyAPIRequest, IAlchemyAPIUrlCombinableRequest
    {
        protected override string RequestPath
        {
            get { return string.IsNullOrEmpty(Target) ? "url/URLGetTextSentiment" : "url/URLGetTargetedSentiment"; }
        }
        public AlchemyUrlSentimentRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
    }
}
