namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyHtmlEntitiesRequest : AlchemyHtmlEntitiesRequestBase, IAlchemyAPIHtmlRequest, ICombinableAlchemyAPIRequest
    {
        private const string htmlKey = "html";
        protected override string RequestPath
        {
            get { return "html/HTMLGetRankedNamedEntities"; }
        }
        public AlchemyHtmlEntitiesRequest(string html, AlchemyClient client):base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
    }
}
