using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlRelationsRequest : AlchemyHtmlRelationsRequestBase
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
