using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlCleanTextRequest : AlchemyCleanTextRequestBase, IAlchemyAPIUrlRequest
    {
        public AlchemyUrlCleanTextRequest (Uri url, AlchemyClient client):base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetText"; }
        }
    }
}
