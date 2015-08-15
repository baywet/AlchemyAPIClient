﻿namespace AlchemyAPIClient.Requests
{
    public class AlchemyHtmlTitleRequest : AlchemyTitleRequestBase, IAlchemyAPIHtmlRequest, ICombinableAlchemyAPIRequest
    {
        protected const string htmlKey = "html";
        public AlchemyHtmlTitleRequest(string html, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
        protected override string RequestPath
        {
            get { return "html/HTMLGetTitle"; }
        }
    }
}
