using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyTextTaxonomiesRequest : AlchemyTaxonomiesRequestBase
    {
        protected const string textKey = "text";
        protected override string RequestPath
        {
            get { return "text/TextGetRankedTaxonomy"; }
        }
        public AlchemyTextTaxonomiesRequest(string text, AlchemyClient client)
            : base(client)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException("text");
            Text = text;
        }
        public string Text { get { return GetParameter(textKey); } set { AddOrUpdateParameter(textKey, value); } }
    }
}
