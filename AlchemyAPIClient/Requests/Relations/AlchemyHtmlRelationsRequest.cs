namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyHtmlRelationsRequest : AlchemyHtmlRelationsRequestBase, IAlchemyAPIHtmlRequest, ICombinableAlchemyAPIRequest
    {
        private const string htmlKey = "html";
        public AlchemyHtmlRelationsRequest(string html, AlchemyClient client):base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
        protected override string RequestPath
        {
            get { return "html/HTMLGetRelations"; }
        }
    }
}
