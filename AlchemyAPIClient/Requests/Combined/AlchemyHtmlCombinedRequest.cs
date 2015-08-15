using System;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.Requests.Combined
{
    public sealed class AlchemyHtmlCombinedRequest : AlchemyCombinedRequestBase<IAlchemyAPIHtmlCombinableRequest>
    {
        private const string htmlKey = "html";
        public AlchemyHtmlCombinedRequest(AlchemyClient client, IEnumerable<IAlchemyAPIHtmlCombinableRequest> combinedCalls) : base(client, combinedCalls)
        {
            if (combinedCalls.Any(x => !(x is IAlchemyAPIHtmlRequest)))
                throw new ArgumentException(nameof(combinedCalls));
            AddRequiredParameter(htmlKey);
        }
        protected override void AdditionalParametersHandling()
        {
            base.AdditionalParametersHandling();
            AddOrUpdateParameter(htmlKey, CombinedCalls.Select(x => x.Html).First());
        }
        protected override string RequestPath
        {
            get
            {
                return "text/TextGetCombinedData";
            }
        }
    }
}
