namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlPublicationDateRequest : AlchemyPublicationDateRequestBase, IAlchemyAPIHtmlRequest, ICombinableAlchemyAPIRequest, IAlchemyAPIHtmlCombinableRequest
    {
        private const string htmlKey = "html";
        protected override string RequestPath
        {
            get { return "html/HTMLGetPubDate"; }
        }
        public AlchemyHtmlPublicationDateRequest(string html, AlchemyClient client):base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
    }
}
