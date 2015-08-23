using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlPublicationDateRequest : AlchemyPublicationDateRequestBase, IAlchemyAPIUrlRequest, ICombinableAlchemyAPIRequest, IAlchemyAPIUrlCombinableRequest
    {
        private const string baseUrlKey = "baseUrl";
        protected override string RequestPath
        {
            get
            {
                return "url/URLGetPubDate";
            }
        }
        public AlchemyUrlPublicationDateRequest(Uri url, AlchemyClient client):base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        public Uri BaseUrl { get { return GetUriParameter(baseUrlKey); } set { AddOrUpdateParameter(baseUrlKey, value); } }
    }
}
