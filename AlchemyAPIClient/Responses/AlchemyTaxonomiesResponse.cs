using System.Collections.Generic;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyTaxonomiesResponse : AlchemyResponseBase<AlchemyTaxonomy>
    {
        public List<AlchemyTaxonomy> Taxonomy { get; set; }
    }
}
