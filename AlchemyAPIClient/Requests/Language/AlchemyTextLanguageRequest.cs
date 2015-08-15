namespace AlchemyAPIClient.Requests
{
    public class AlchemyTextLanguageRequest : AlchemyLanguageRequestBase, IAlchemyAPITextRequest
    {
        protected const string textKey = "text";
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
