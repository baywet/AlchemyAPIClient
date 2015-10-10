using System.Collections.Generic;

namespace AlchemyAPIClient
{
    public class AlchemySubject
    {
        public string Text { get; set; }
        public AlchemySentiment Sentiment { get; set; }
        public List<AlchemyEntity> Entities { get; set; }
        public List<AlchemyKeyword> Keywords { get; set; }
    }
}
