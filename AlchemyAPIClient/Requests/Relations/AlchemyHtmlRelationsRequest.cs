namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlRelationsRequest : AlchemyHtmlRelationsRequestBase, IAlchemyAPIHtmlRequest, ICombinableAlchemyAPIRequest
    {
        protected const string htmlKey = "html";
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
