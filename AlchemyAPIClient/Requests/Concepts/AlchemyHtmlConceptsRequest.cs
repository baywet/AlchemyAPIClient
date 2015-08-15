namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlConceptsRequest : AlchemyHtmlConceptsRequestBase, IAlchemyAPIHtmlRequest, ICombinableAlchemyAPIRequest
    {
        protected const string htmlKey = "html";
        protected override string RequestPath
        {
            get { return "html/HTMLGetRankedConcepts"; }
        }
        public AlchemyHtmlConceptsRequest(string html, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
    }
}
