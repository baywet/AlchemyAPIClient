using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlTaxonomiesRequest : AlchemyHtmlTaxonomiesRequestBase
    {
        protected const string htmlKey = "html";
        protected override string RequestPath
        {
            get { return "html/HTMLGetRankedTaxonomy"; }
        }
        public AlchemyHtmlTaxonomiesRequest(string html, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
    }
}
