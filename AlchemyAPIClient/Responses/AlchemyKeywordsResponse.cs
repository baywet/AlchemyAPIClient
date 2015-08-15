using System.Collections.Generic;

namespace AlchemyAPIClient.Responses
{
    public class AlchemyKeywordsResponse : AlchemyResponseBase<AlchemyKeyword>
    {
        public List<AlchemyKeyword> Keywords { get; set; }
    }
}
