namespace AlchemyAPIClient.Responses
{
    public abstract class AlchemyResponseBase<T> where T : class
    {
        public AlchemyAPIResponseStatus Status { get; internal set; }
        public string Usage { get; internal set; }
        public string Url { get; internal set; }
        public string Language { get; internal set; }
        public int TotalTransactions { get; internal set; }
        public string Text { get; internal set; }
        public string StatusInfo { get; internal set; }
        public int NumberOfRetries { get; internal set; }
    }
    public enum AlchemyAPIResponseStatus
    {
        OK,
        ERROR
    }
}
