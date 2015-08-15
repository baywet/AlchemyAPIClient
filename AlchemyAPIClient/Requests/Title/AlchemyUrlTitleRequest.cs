using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlTitleRequest : AlchemyTitleRequestBase
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
