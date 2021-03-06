﻿namespace AlchemyAPIClient.Requests
{
    public sealed class AlchemyTextTaxonomiesRequest : AlchemyTaxonomiesRequestBase, IAlchemyAPITextRequest, ICombinableAlchemyAPIRequest, IAlchemyAPITextCombinableRequest
    {
        private const string textKey = "text";
        protected override string RequestPath
        {
            get { return "text/TextGetRankedTaxonomy"; }
        }
        public AlchemyTextTaxonomiesRequest(string text, AlchemyClient client)
            : base(client)
        {
            AddRequiredParameter(textKey);
            Text = text;
        }
        public string Text { get { return GetParameter(textKey); } set { AddOrUpdateParameter(textKey, value); } }
    }
}
