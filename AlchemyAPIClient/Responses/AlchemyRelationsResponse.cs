using System.Collections.Generic;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyRelationsResponse : AlchemyResponseBase<AlchemyRelation>
    {
        public List<AlchemyRelation> Relations { get; set; }
    }
}
