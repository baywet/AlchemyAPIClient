using System;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.Requests.Combined
{
    public sealed class AlchemyUrlCombinedRequest : AlchemyCombinedRequestBase
    {
        public AlchemyUrlCombinedRequest(AlchemyClient client, IEnumerable<ICombinableAlchemyAPIRequest> combinedCalls) : base(client, combinedCalls)
        {
            if (combinedCalls.Any(x => !(x is IAlchemyAPIUrlRequest)))
                throw new ArgumentException(nameof(combinedCalls));
            AddRequiredParameter(urlKey);
        }
        protected override void AdditionalParametersHandling()
        {
            base.AdditionalParametersHandling();
            AddOrUpdateParameter(urlKey, CombinedCalls.Cast<IAlchemyAPIUrlRequest>().Select(x => x.Url).First());
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
