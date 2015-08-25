using AlchemyAPIClient.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Requests.Combined
{
    public abstract class AlchemyCombinedRequestBase<requestType> : AlchemyRequestBase<IEnumerable<AlchemyResponseBase<requestType>>, AlchemyCombinedResponse<requestType>> where requestType : class, ICombinableAlchemyAPIRequest
    {
        private const string showSourceTextKey = "showSourceText";
        private const string extractKey = "extract";
        protected const string urlKey = "url";
        public AlchemyCombinedRequestBase(AlchemyClient client, IEnumerable<requestType> combinedCalls) : base(client)
        {
            if (combinedCalls == null && !combinedCalls.Any())
                throw new ArgumentNullException(nameof(combinedCalls));
            CombinedCalls = combinedCalls;
            AddRequiredParameter(extractKey);
        }
        protected override async Task<T> GetTypedResponseFromText<T, U>(string textResponse, CancellationToken token)
        {
            var combined = await base.GetTypedResponseFromText<AlchemyCombinedResponse<requestType>, IEnumerable<AlchemyResponseBase<requestType>>>(textResponse, token);
            if (CombinedCalls.Any(x => x is AlchemyAuthorRequestBase))
                combined.AuthorResponse = await base.GetTypedResponseFromText<AlchemyAuthorResponse, string>(textResponse, token);
            if (CombinedCalls.Any(x => x is AlchemySentimentRequestBase))
                combined.SentimentResponse = await base.GetTypedResponseFromText<AlchemySentimentResponse, AlchemySentiment>(textResponse, token);
            if (CombinedCalls.Any(x => x is AlchemyKeywordsRequestBase))
                combined.KeywordsResponse = await base.GetTypedResponseFromText<AlchemyKeywordsResponse, AlchemyKeyword>(textResponse, token);
            if (CombinedCalls.Any(x => x is AlchemyEntitiesRequestBase))
                combined.EntitiesResponse = await base.GetTypedResponseFromText<AlchemyEntitiesResponse, AlchemyEntity>(textResponse, token);
            if (CombinedCalls.Any(x => x is AlchemyConceptsRequestBase))
                combined.ConceptsResponse = await base.GetTypedResponseFromText<AlchemyConceptsResponse, AlchemyConcept>(textResponse, token);
            if (CombinedCalls.Any(x => x is AlchemyRelationsRequestBase))
                combined.RelationResponse = await base.GetTypedResponseFromText<AlchemyRelationsResponse, AlchemyRelation>(textResponse, token);
            if (CombinedCalls.Any(x => x is AlchemyTaxonomiesRequestBase))
                combined.TaxonomiesResponse = await base.GetTypedResponseFromText<AlchemyTaxonomiesResponse, AlchemyTaxonomy>(textResponse, token);
            if (CombinedCalls.Any(x => x is AlchemyTitleRequestBase))
                combined.TitleResponse = await base.GetTypedResponseFromText<AlchemyTitleResponse, string>(textResponse, token);
            return combined as T;
        }
        protected override void AdditionalParametersHandling()
        {
            AddOrUpdateParameter(extractKey, CombinedCalls.Select(x => x.CallName).Distinct().Aggregate((x, y) => x + "," + y));
        }
        public IEnumerable<requestType> CombinedCalls { get; private set; }
        public bool ShowSourceText { get { return GetBooleanParameter(showSourceTextKey); } set { AddOrUpdateParameter(showSourceTextKey, value); } }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
    }
}
