namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyTextLanguageRequest : AlchemyLanguageRequestBase, IAlchemyAPITextRequest
    {
        private const string textKey = "text";
        public AlchemyTextLanguageRequest(string text, AlchemyClient client):base(client)
        {
            AddRequiredParameter(textKey);
            Text = text;
        }
        public string Text { get { return GetParameter(textKey); } set { AddOrUpdateParameter(textKey, value); } }
        protected override string RequestPath
        {
            get { return "text/TextGetLanguage"; }
        }
    }
}
