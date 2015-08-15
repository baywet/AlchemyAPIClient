namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlAuthorRequest : AlchemyAuthorRequestBase, IAlchemyAPIHtmlRequest, ICombinableAlchemyAPIRequest
    {
        protected const string htmlKey = "html";
        public AlchemyHtmlAuthorRequest(string html, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
        protected override string RequestPath
        {
            get { return "html/HTMLGetAuthor"; }
        }
    }
}
