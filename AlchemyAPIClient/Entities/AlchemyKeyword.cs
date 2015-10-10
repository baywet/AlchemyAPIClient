namespace AlchemyAPIClient
{
    public class AlchemyKeyword
    {
        public string Text { get; set; }
        public double Relevance { get; set; }
        public AlchemyGraph KnowledgeGraph { get; set; }
        public AlchemySentiment Sentiment { get; set; }
    }
}
