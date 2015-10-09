using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlFeedRequest : AlchemyFeedRequestBase, ICombinableAlchemyAPIRequest, IAlchemyAPIUrlRequest, IAlchemyAPIUrlCombinableRequest
    {
        public AlchemyUrlFeedRequest(Uri url, AlchemyClient client) : base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get
            {
                return "url/URLGetFeedLinks";
            }
        }
    }
}
