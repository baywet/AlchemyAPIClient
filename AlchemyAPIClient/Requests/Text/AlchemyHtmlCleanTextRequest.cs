namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyHtmlCleanTextRequest : AlchemyCleanTextRequestBase, IAlchemyAPIHtmlRequest
    {
        private const string htmlKey = "html";
        public AlchemyHtmlCleanTextRequest(string html, AlchemyClient client): base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
        protected override string RequestPath
        {
            get { return "html/HTMLGetText"; }
        }
    }
}
