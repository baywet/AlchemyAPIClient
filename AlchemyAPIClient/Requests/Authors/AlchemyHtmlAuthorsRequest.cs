namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlAuthorsRequest : AlchemyAuthorsRequestBase, IAlchemyAPIHtmlRequest
    {
        protected const string htmlKey = "html";
        public AlchemyHtmlAuthorsRequest(string html, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
        protected override string RequestPath
        {
            get { return "html/HTMLGetAuthors"; }
        }
    }
}
