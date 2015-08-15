using System;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.Requests.Combined
{
    public sealed class AlchemyUrlCombinedRequest : AlchemyCombinedRequestBase<IAlchemyAPIUrlCombinableRequest>
    {
        public AlchemyUrlCombinedRequest(AlchemyClient client, IEnumerable<IAlchemyAPIUrlCombinableRequest> combinedCalls) : base(client, combinedCalls)
        {
            if (combinedCalls.Any(x => !(x is IAlchemyAPIUrlRequest)))
                throw new ArgumentException(nameof(combinedCalls));
            AddRequiredParameter(urlKey);
        }
        protected override void AdditionalParametersHandling()
        {
            base.AdditionalParametersHandling();
            AddOrUpdateParameter(urlKey, CombinedCalls.Select(x => x.Url).First());
        }
        protected override string RequestPath
        {
            get
            {
                return "url/URLGetCombinedData";
            }
        }
    }
}
