namespace AlchemyAPIClient.Requests
{
    public class AlchemyTextRelationsRequest : AlchemyRelationsRequestBase, IAlchemyAPITextRequest, ICombinableAlchemyAPIRequest, IAlchemyAPITextCombinableRequest
    {
        protected const string textKey = "text";
        public AlchemyTextRelationsRequest(string text, AlchemyClient client):base(client)
        {
            AddRequiredParameter(textKey);
            Text = text;
        }
        public string Text { get { return GetParameter(textKey); } set { AddOrUpdateParameter(textKey, value); } }
        protected override string RequestPath
        {
            get { return "text/TextGetRelations"; }
        }
    }
}
