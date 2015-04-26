using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyEntitiesResponse : AlchemyResponseBase<AlchemyEntity>
    {
        public List<AlchemyEntity> Entities { get; set; }
    }
}
