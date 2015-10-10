using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlMicroFormatRequest : AlchemyMicroFormatRequestBase
    {
        public AlchemyUrlMicroFormatRequest(Uri url, AlchemyClient client) : base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath { get { return "url/URLGetMicroformatData"; } }
    }
}
