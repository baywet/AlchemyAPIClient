using System;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlLanguageRequest : AlchemyHtmlLanguageRequestBase
    {
        public AlchemyUrlLanguageRequest(Uri url, AlchemyClient client):base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetLanguage"; }
        }
    }
}
