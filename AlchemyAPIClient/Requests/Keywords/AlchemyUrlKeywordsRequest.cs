using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlKeywordsRequest : AlchemyHtmlKeywordsRequestBase
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
