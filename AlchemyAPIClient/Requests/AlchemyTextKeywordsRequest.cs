using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyTextKeywordsRequest : AlchemyKeywordsRequestBase
    {
        protected const string textKey = "text";
        public AlchemyTextKeywordsRequest(string text, AlchemyClient client)
            : base(client)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException("text");
            Text = text;
        }
        public string Text { get { return GetParameter(textKey); } set { AddOrUpdateParameter(textKey, value); } }
        protected override string RequestPath
        {
            get { return "text/TextGetRankedKeywords"; }
        }
    }
}
