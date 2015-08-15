using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlRawTextRequest : AlchemyRawTextRequestBase
    {
        public AlchemyUrlRawTextRequest(Uri url, AlchemyClient client):base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetRawText"; }
        }
    }
}
