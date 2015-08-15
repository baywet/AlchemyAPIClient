namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlKeywordsRequest : AlchemyHtmlKeywordsRequestBase, IAlchemyAPIHtmlRequest
    {
        protected const string htmlKey = "html";
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
