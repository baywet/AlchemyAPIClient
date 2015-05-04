using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlRelationsRequest : AlchemyHtmlRelationsRequestBase
    {
        protected const string htmlKey = "html";
        public AlchemyHtmlRelationsRequest(string html, AlchemyClient client):base(client)
        {
            if (string.IsNullOrWhiteSpace(html))
                throw new ArgumentNullException("html");
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
        protected override string RequestPath
        {
            get { return "html/HTMLGetRelations"; }
        }
    }
}
