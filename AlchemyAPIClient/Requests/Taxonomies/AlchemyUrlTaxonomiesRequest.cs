using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlTaxonomiesRequest : AlchemyHtmlTaxonomiesRequestBase
    {
        public AlchemyUrlTaxonomiesRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            if (url == null)
                throw new ArgumentNullException("url");
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetRankedTaxonomy"; }
        }
    }
}
