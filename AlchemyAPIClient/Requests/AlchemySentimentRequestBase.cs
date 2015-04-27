using AlchemyAPIClient.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests
{
    public abstract class AlchemySentimentRequestBase : AlchemyRequestBase<AlchemySentiment, AlchemySentimentResponse>
    {
        protected const string urlKey = "url";
        protected const string showSourceTextKey = "showSourceText";
        protected const string targetKey = "target";
        public AlchemySentimentRequestBase(AlchemyClient client):base(client)
        {

        }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
        public bool ShowSourceText { get { return GetBooleanParameter(showSourceTextKey); } set { AddOrUpdateParameter(showSourceTextKey, value); } }
        public string Target { get { return GetParameter(targetKey); } set { AddOrUpdateParameter(targetKey, value); } }
    }
}
