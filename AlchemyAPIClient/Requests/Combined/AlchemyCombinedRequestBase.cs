using AlchemyAPIClient.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyAPIClient.Requests.Combined
{
    public abstract class AlchemyCombinedRequestBase : AlchemyRequestBase<IEnumerable<AlchemyResponseBase<ICombinableAlchemyAPIRequest>>, AlchemyCombinedResponse>
    {
        private const string showSourceTextKey = "showSourceText";
        private const string extractKey = "extract";
        protected const string urlKey = "url";
        public AlchemyCombinedRequestBase(AlchemyClient client, IEnumerable<ICombinableAlchemyAPIRequest> combinedCalls) : base(client)
        {
            if (combinedCalls == null && !combinedCalls.Any())
                throw new ArgumentNullException(nameof(combinedCalls));
            CombinedCalls = combinedCalls;
            AddRequiredParameter(extractKey);
        }
        protected override T GetTypedResponseFromText<T, U>(string textResponse)
        {
            var combined = base.GetTypedResponseFromText<AlchemyCombinedResponse, IEnumerable<AlchemyResponseBase<ICombinableAlchemyAPIRequest>>>(textResponse);
            if (CombinedCalls.Any(x => x is AlchemyAuthorRequestBase))
                combined.AuthorResponse = base.GetTypedResponseFromText<AlchemyAuthorResponse, string>(textResponse);
            if (CombinedCalls.Any(x => x is AlchemySentimentRequestBase))
                combined.SentimentResponse = base.GetTypedResponseFromText<AlchemySentimentResponse, AlchemySentiment>(textResponse);
            if (CombinedCalls.Any(x => x is AlchemyKeywordsRequestBase))
                combined.KeywordsResponse = base.GetTypedResponseFromText<AlchemyKeywordsResponse, AlchemyKeyword>(textResponse);
            if (CombinedCalls.Any(x => x is AlchemyEntitiesRequestBase))
                combined.EntitiesResponse = base.GetTypedResponseFromText<AlchemyEntitiesResponse, AlchemyEntity>(textResponse);
            if (CombinedCalls.Any(x => x is AlchemyConceptsRequestBase))
                combined.ConceptsResponse = base.GetTypedResponseFromText<AlchemyConceptsResponse, AlchemyConcept>(textResponse);
            if (CombinedCalls.Any(x => x is AlchemyRelationsRequestBase))
                combined.RelationResponse = base.GetTypedResponseFromText<AlchemyRelationsResponse, AlchemyRelation>(textResponse);
            if (CombinedCalls.Any(x => x is AlchemyTaxonomiesRequestBase))
                combined.TaxonomiesResponse = base.GetTypedResponseFromText<AlchemyTaxonomiesResponse, AlchemyTaxonomy>(textResponse);
            if (CombinedCalls.Any(x => x is AlchemyTitleRequestBase))
                combined.TitleResponse = base.GetTypedResponseFromText<AlchemyTitleResponse, string>(textResponse);
            return combined as T;
        }
        protected override void AdditionalParametersHandling()
        {
            AddOrUpdateParameter(extractKey, CombinedCalls.Select(x => x.CallName).Distinct().Aggregate((x, y) => x + "," + y));
        }
        public IEnumerable<ICombinableAlchemyAPIRequest> CombinedCalls { get; private set; }
        public bool ShowSourceText { get { return GetBooleanParameter(showSourceTextKey); } set { AddOrUpdateParameter(showSourceTextKey, value); } }
        public Uri Url { get { return GetUriParameter(urlKey); } set { AddOrUpdateParameter(urlKey, value); } }
    }
}
