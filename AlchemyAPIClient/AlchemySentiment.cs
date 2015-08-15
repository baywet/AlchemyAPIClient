namespace AlchemyAPIClient
{
    public class AlchemySentiment
    {
        public AlchemySentimentType Type { get; set; }
        public double Score { get; set; }
        public int Mixed { get; set; }
    }
    public enum AlchemySentimentType
    {
        Negative,
        Neutral,
        Mixed,
        Positive
    }
}
