namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlEntitiesRequest : AlchemyHtmlEntitiesRequestBase
    {
        protected const string htmlKey = "html";
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
