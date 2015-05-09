using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyUrlSentimentRequest : AlchemyHtmlSentimentBase
    {
        protected override string RequestPath
        {
            get { return string.IsNullOrEmpty(Target) ? "url/URLGetTextSentiment" : "url/URLGetTargetedSentiment"; }
        }
        public AlchemyUrlSentimentRequest(Uri url, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(urlKey);
            Url = url;
        }
    }
}
