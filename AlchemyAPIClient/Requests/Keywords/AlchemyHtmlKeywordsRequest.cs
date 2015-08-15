namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyHtmlKeywordsRequest : AlchemyHtmlKeywordsRequestBase, IAlchemyAPIHtmlRequest
    {
        private const string htmlKey = "html";
        protected override string RequestPath
        {
            get { return "html/HTMLGetRankedKeywords"; }
        }
        public AlchemyHtmlKeywordsRequest(string html, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
    }
}
