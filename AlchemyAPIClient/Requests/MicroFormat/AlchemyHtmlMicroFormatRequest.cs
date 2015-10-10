namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlMicroFormatRequest : AlchemyMicroFormatRequestBase
    {
        private const string htmlKey = "html";
        public AlchemyHtmlMicroFormatRequest(string html, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
        protected override string RequestPath { get { return "html/HTMLGetMicroformatData"; } }
    }
}
