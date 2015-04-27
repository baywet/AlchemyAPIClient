using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlConceptsRequest : AlchemyHtmlConceptsRequestBase
    {
        protected const string baseUrlKey = "baseUrl";
        public AlchemyUrlConceptsRequest(Uri url, AlchemyClient client):base(client)
        {
            if (url == null)
                throw new ArgumentNullException("url");
            Url = url;
        }
        protected override string RequestPath
        {
            get { return "url/URLGetRankedConcepts"; }
        }
        public Uri BaseUrl { get { return GetUriParameter(baseUrlKey); } set { AddOrUpdateParameter(baseUrlKey, value); } }
    }
}
