using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlAuthorRequest : AlchemyAuthorRequestBase, IAlchemyAPIUrlRequest
    {
        public AlchemyUrlAuthorRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetAuthor"; }
        }
    }
}
