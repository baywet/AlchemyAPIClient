using System.Collections.Generic;

namespace AlchemyAPIClient
{
    public class AlchemyObject
    {
        public string Text { get; set; }
        public AlchemySentiment Sentiment { get; set; }
        public AlchemySentiment SentimentFromSubject { get; set; }
        public List<AlchemyEntity> Entities { get; set; }
        public List<AlchemyKeyword> Keywords { get; set; }
    }
}
