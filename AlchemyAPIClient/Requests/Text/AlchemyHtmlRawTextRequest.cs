﻿namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyHtmlRawTextRequest : AlchemyRawTextRequestBase, IAlchemyAPIHtmlRequest
    {
        private const string htmlKey = "html";
        public AlchemyHtmlRawTextRequest(string html, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(htmlKey);
            Html = html;
        }
        public string Html { get { return GetParameter(htmlKey); } set { AddOrUpdateParameter(htmlKey, value); } }
        protected override string RequestPath
        {
            get { return "html/HTMLGetRawText"; }
        }
    }
}
