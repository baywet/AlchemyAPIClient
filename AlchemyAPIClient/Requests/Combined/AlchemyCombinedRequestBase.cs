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
            combined.AuthorResponse = base.GetTypedResponseFromText<AlchemyAuthorResponse, string>(textResponse);
            combined.SentimentResponse = base.GetTypedResponseFromText<AlchemySentimentResponse, AlchemySentiment>(textResponse);
            combined.KeywordsResponse = base.GetTypedResponseFromText<AlchemyKeywordsResponse, AlchemyKeyword>(textResponse);
            combined.EntitiesResponse = base.GetTypedResponseFromText<AlchemyEntitiesResponse, AlchemyEntity>(textResponse);
            combined.ConceptsResponse = base.GetTypedResponseFromText<AlchemyConceptsResponse, AlchemyConcept>(textResponse);
            combined.RelationResponse = base.GetTypedResponseFromText<AlchemyRelationsResponse, AlchemyRelation>(textResponse);
            combined.TaxonomiesResponse = base.GetTypedResponseFromText<AlchemyTaxonomiesResponse, AlchemyTaxonomy>(textResponse);
            combined.TitleResponse = base.GetTypedResponseFromText<AlchemyTitleResponse, string>(textResponse);
            return combined as T;
        }
        protected override void AdditionalParametersHandling()
        {
            AddOrUpdateParameter(extractKey, CombinedCalls.Select(x => x.CallName).Distinct().Aggregate((x, y) => x + "," + y));
        }
        public IEnumerable<ICombinableAlchemyAPIRequest> CombinedCalls { get; private set; }
        public bool ShowSourceText { get { return GetBooleanParameter(showSourceTextKey); } set { AddOrUpdateParameter(showSourceTextKey, value); } }
    }
}
