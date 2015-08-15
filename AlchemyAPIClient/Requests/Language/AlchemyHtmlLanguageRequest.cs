namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlLanguageRequest : AlchemyHtmlLanguageRequestBase
    {
        protected const string htmlKey = "html";
        public AlchemyHtmlLanguageRequest(string html, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        protected override string RequestPath
        {
            get { return "html/HTMLGetLanguage"; }
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
    }
}
