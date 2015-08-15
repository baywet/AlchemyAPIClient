namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyTextEntitiesRequest : AlchemyEntitiesRequestBase, IAlchemyAPITextRequest, ICombinableAlchemyAPIRequest, IAlchemyAPITextCombinableRequest
    {
        private const string textKey = "text";
        protected override string RequestPath
        {
            get { return "text/TextGetRankedNamedEntities"; }
        }
        public AlchemyTextEntitiesRequest(string text, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(textKey);
            Text = text;
        }
        public string Text { get { return GetParameter(textKey); } set { AddOrUpdateParameter(textKey, value); } }
    }
}
