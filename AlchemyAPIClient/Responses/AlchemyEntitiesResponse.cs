using System.Collections.Generic;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyEntitiesResponse : AlchemyResponseBase<AlchemyEntity>
    {
        public List<AlchemyEntity> Entities { get; set; }
    }
}
