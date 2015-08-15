using System.Collections.Generic;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyConceptsResponse : AlchemyResponseBase<AlchemyConcept>
    {
        public List<AlchemyConcept> Concepts { get;set;}
    }
}
