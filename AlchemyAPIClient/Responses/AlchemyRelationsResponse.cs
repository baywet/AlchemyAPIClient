using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyRelationsResponse : AlchemyResponseBase<AlchemyRelation>
    {
        public List<AlchemyRelation> Relations { get; set; }
    }
}
