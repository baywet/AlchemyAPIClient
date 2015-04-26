using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlConceptsRequest : AlchemyHtmlConceptsRequestBase
    {
        protected const string htmlKey = "html";
        protected override string RequestPath
        {
            get { return "html/HTMLGetRankedConcepts"; }
        }
        public AlchemyHtmlConceptsRequest(string html, AlchemyClient client)
            : base(client)
        {
            if (string.IsNullOrWhiteSpace(html))
                throw new ArgumentNullException(html);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
    }
}
