using System.Collections.Generic;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyCombinedResponse<T> : AlchemyResponseBase<IEnumerable<AlchemyResponseBase<T>>> where T : class, ICombinableAlchemyAPIRequest
    {
        public AlchemyAuthorResponse AuthorResponse { get; set; }
        public AlchemyKeywordsResponse KeywordsResponse { get; set; }
        public AlchemyEntitiesResponse EntitiesResponse { get; set; }
        public AlchemyTitleResponse TitleResponse { get; set; }
        public AlchemyTaxonomiesResponse TaxonomiesResponse { get; set; }
        public AlchemyConceptsResponse ConceptsResponse { get; set; }
        public AlchemyRelationsResponse RelationResponse { get; set; }
        public AlchemySentimentResponse SentimentResponse { get; set; }
    }
}
