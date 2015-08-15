using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlAuthorsRequest: AlchemyAuthorsRequestBase
    {
        public AlchemyUrlAuthorsRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetAuthors"; }
        }
    }
}
