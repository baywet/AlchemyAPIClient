using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyTaxonomiesResponse : AlchemyResponseBase<AlchemyTaxonomy>
    {
        public List<AlchemyTaxonomy> Taxonomy { get; set; }
    }
}
