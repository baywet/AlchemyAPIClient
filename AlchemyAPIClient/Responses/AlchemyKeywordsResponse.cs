using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyKeywordsResponse : AlchemyResponseBase<AlchemyKeyword>
    {
        public List<AlchemyKeyword> Keywords { get; set; }
    }
}
