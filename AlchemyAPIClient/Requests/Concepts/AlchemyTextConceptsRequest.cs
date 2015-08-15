namespace AlchemyAPIClient.Requests
{
    public class AlchemyTextConceptsRequest : AlchemyConceptsRequestBase, IAlchemyAPITextRequest
    {
        protected const string textKey = "text";
        protected override string RequestPath
        {
            get { return "text/TextGetRankedConcepts"; }
        }
        public AlchemyTextConceptsRequest(string text, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(textKey);
            Text = text;
        }
        public string Text { get { return GetParameter(textKey); } set { AddOrUpdateParameter(textKey, value); } }
    }
}
