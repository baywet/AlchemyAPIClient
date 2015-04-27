using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public class AlchemyTextSentimentRequest : AlchemySentimentRequestBase
    {
        protected const string textKey = "text";
        protected override string RequestPath
        {
            get { return string.IsNullOrEmpty(Target) ? "text/TextGetTextSentiment" : "text/TextGetTargetedSentiment"; }
        }
        public AlchemyTextSentimentRequest(string text, AlchemyClient client)
            : base(client)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException("text");
            Text = text;
        }
        public string Text { get { return GetParameter(textKey); } set { AddOrUpdateParameter(textKey, value); } }
    }
}
