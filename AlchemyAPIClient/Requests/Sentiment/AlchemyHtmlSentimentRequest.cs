using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlSentimentRequest : AlchemyHtmlSentimentBase
    {
        protected const string htmlKey = "html";
        protected const string cqueryKey = "cquery";
        protected override string RequestPath
        {
            get { return string.IsNullOrEmpty(Target) ? "html/HTMLGetTextSentiment" : "html/HTMLGetTargetedSentiment"; }
        }
        public AlchemyHtmlSentimentRequest(string html, AlchemyClient client)
            : base(client)
        {
            if (string.IsNullOrWhiteSpace(html))
                throw new ArgumentNullException("html");
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
        public bool Cquery { get { return GetBooleanParameter(cqueryKey); } set { AddOrUpdateParameter(cqueryKey, value); } }
    }
}
