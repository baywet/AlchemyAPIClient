namespace AlchemyAPIClient.Requests
{
    public class AlchemyTextEntitiesRequest : AlchemyEntitiesRequestBase
    {
        protected const string textKey = "text";
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
