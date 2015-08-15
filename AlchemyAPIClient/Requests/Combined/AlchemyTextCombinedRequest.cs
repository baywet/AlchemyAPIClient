using System;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.Requests.Combined
{
    public sealed class AlchemyTextCombinedRequest : AlchemyCombinedRequestBase
    {
        private const string textKey = "text";
        public AlchemyTextCombinedRequest(AlchemyClient client, IEnumerable<ICombinableAlchemyAPIRequest> combinedCalls) : base(client, combinedCalls)
        {
            if (combinedCalls.Any(x => !(x is IAlchemyAPITextRequest)))
                throw new ArgumentException(nameof(combinedCalls));
            AddRequiredParameter(textKey);
        }
        protected override void AdditionalParametersHandling()
        {
            base.AdditionalParametersHandling();
            AddOrUpdateParameter(textKey, CombinedCalls.Cast<IAlchemyAPITextRequest>().Select(x => x.Text).First());
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
