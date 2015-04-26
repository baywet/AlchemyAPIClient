using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyConceptsResponse : AlchemyResponseBase<AlchemyConcept>
    {
        public List<AlchemyConcept> Concepts { get;set;}
    }
}
