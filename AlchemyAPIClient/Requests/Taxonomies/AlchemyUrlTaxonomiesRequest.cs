using System;

namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyUrlTaxonomiesRequest : AlchemyHtmlTaxonomiesRequestBase, IAlchemyAPIUrlRequest, ICombinableAlchemyAPIRequest, IAlchemyAPIUrlCombinableRequest
    {
        public AlchemyUrlTaxonomiesRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            if (url == null)
                throw new ArgumentNullException(nameof(url));
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetRankedTaxonomy"; }
        }
    }
}
