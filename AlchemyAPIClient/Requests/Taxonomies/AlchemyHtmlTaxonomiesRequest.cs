namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlTaxonomiesRequest : AlchemyHtmlTaxonomiesRequestBase, IAlchemyAPIHtmlRequest
    {
        protected const string htmlKey = "html";
        protected override string RequestPath
        {
            get { return "html/HTMLGetRankedTaxonomy"; }
        }
        public AlchemyHtmlTaxonomiesRequest(string html, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
    }
}
