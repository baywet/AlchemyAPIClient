namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlFeedRequest : AlchemyFeedRequestBase, ICombinableAlchemyAPIRequest, IAlchemyAPIHtmlRequest, IAlchemyAPIHtmlCombinableRequest
    {
        private const string htmlKey = "html";
        public AlchemyHtmlFeedRequest(string html, AlchemyClient client):base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        protected override string RequestPath
        {
            get
            {
                return "html/HTMLGetFeedLinks";
            }
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
    }
}
