namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyTextKeywordsRequest : AlchemyKeywordsRequestBase, IAlchemyAPITextRequest, ICombinableAlchemyAPIRequest, IAlchemyAPITextCombinableRequest
    {
        private const string textKey = "text";
        public AlchemyTextKeywordsRequest(string text, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(textKey);
            Text = text;
        }
        public string Text { get { return GetParameter(textKey); } set { AddOrUpdateParameter(textKey, value); } }
        protected override string RequestPath
        {
            get { return "text/TextGetRankedKeywords"; }
        }
    }
}
